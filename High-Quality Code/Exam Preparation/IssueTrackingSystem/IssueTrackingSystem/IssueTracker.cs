namespace IssueTrackingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using IssueTrackingSystem.Contracts;

    /// <summary>
    /// class Implement IIssueTracker
    /// </summary>
    public class IssueTracker : IIssueTracker
    {
        /// <summary>
        /// Constructor with default data injection
        /// </summary>
        public IssueTracker()
            : this(new IssueTrackerData())
        {
        }

        /// <summary>
        /// Dependancy injection data
        /// </summary>
        /// <param name="data">IIssueTrackerData strategy inplementation</param>
        public IssueTracker(IIssueTrackerData data)
        {
            this.Data = data;
        }

        public IIssueTrackerData Data { get; set; }

        /// <summary>
        /// Register new User in Issue Tracker System
        /// </summary>
        /// <param name="username">User usernsme</param>
        /// <param name="password">User password</param>
        /// <param name="confirmPassword">User confirmed password</param>
        /// <returns>Return different message with result of the registration. Success or Not</returns>
        public string RegisterUser(string username, string password, string confirmPassword)
        {
            if (this.Data.CurrentUser != null)
            {
                return string.Format("There is already a logged in user");
            }

            if (password != confirmPassword)
            {
                return string.Format("The provided passwords do not match", username);
            }

            if (this.Data.Users.ContainsKey(username))
            {
                return string.Format("A user with username {0} already exists", username);
            }

            var user = new User(username, password);
            this.Data.Users.Add(username, user);

            string result = string.Format("User {0} registered successfully", username);
            return result;
        }

        /// <summary>
        /// Login existing User in the Issue Tracker System
        /// </summary>
        /// <param name="username">User usernsme</param>
        /// <param name="password">User password</param>
        /// <returns>Return different message with result of the login. Success or Not</returns>
        public string LoginUser(string username, string password)
        {
            if (this.Data.CurrentUser != null)
            {
                return string.Format("There is already a logged in user");
            }

            if (!this.Data.Users.ContainsKey(username))
            {
                return string.Format("A user with username {0} does not exist", username);
            }

            var user = this.Data.Users[username];
            if (user.PasswortHash != User.HashPassword(password))
            {
                return string.Format("The password is invalid for user {0}", username);
            }

            this.Data.CurrentUser = user;

            return string.Format("User {0} logged in successfully", username);
        }

        /// <summary>
        /// Logout current user from Issue Tracker System
        /// </summary>
        /// <returns>Return different message with result of the logoutin. Success or Not</returns>
        public string LogoutUser()
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            string username = this.Data.CurrentUser.Username;
            this.Data.CurrentUser = null;
            return string.Format("User {0} logged out successfully", username);
        }

        /// <summary>
        /// Create and Register new Issue in Issue Tracker System
        /// </summary>
        /// <param name="title">New Issue titlt</param>
        /// <param name="description">New Issue description</param>
        /// <param name="priority">New Issue priority</param>
        /// <param name="tags">New Issue tags</param>
        /// <returns>Return different message with result of issue creation. Success or Not</returns>
        public string CreateIssue(string title, string description, Common.IssuePriority priority, string[] tags)
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            var issue = new Problem(title, description, priority, tags.Distinct().ToList());
            issue.Id = this.Data.NextIssueId;
            this.Data.IssuesById.Add(issue.Id, issue);
            this.Data.NextIssueId++;

            this.Data.IssuesByUsername[this.Data.CurrentUser.Username].Add(issue);
            foreach (var tag in issue.Tags)
            {
                this.Data.IssuesTags[tag].Add(issue);
            }

            return string.Format("Issue {0} created successfully.", issue.Id);
        }

        /// <summary>
        /// Remove issue by id from Issue Tracker System
        /// </summary>
        /// <param name="issueId">Issue Id</param>
        /// <returns>Return different message with result of issue remove. Success or Not</returns>
        public string RemoveIssue(int issueId)
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            if (!this.Data.IssuesById.ContainsKey(issueId))
            {
                return string.Format("There is no issue with ID {0}", issueId);
            }

            var issue = this.Data.IssuesById[issueId];
            if (!this.Data.IssuesByUsername[this.Data.CurrentUser.Username].Contains(issue))
            {
                return string.Format("The issue with ID {0} does not belong to user {1}", issueId, this.Data.CurrentUser.Username);
            }

            this.Data.IssuesByUsername[this.Data.CurrentUser.Username].Remove(issue);
            foreach (var tag in issue.Tags)
            {
                this.Data.IssuesTags[tag].Remove(issue);
            }

            this.Data.IssuesById.Remove(issue.Id);
            return string.Format("Issue {0} removed", issueId);
        }

        /// <summary>
        /// Adding comment on Issue by provided Id
        /// </summary>
        /// <param name="issueId">Issue id</param>
        /// <param name="text">Comment text</param>
        /// <returns>Return different message with result of comment adding. Success or Not</returns>
        public string AddComment(int issueId, string text)
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            if (!this.Data.IssuesById.ContainsKey(issueId))
            {
                return string.Format("There is no issue with ID {0}", issueId + 1);
            }

            var issue = this.Data.IssuesById[issueId];
            var comment = new Comment(this.Data.CurrentUser, text);
            issue.AddComment(comment);
            this.Data.UserComment[this.Data.CurrentUser].Add(comment);

            return string.Format("Comment added successfully to issue {0}", issue.Id);
        }

        /// <summary>
        /// Get Issues on current login User
        /// </summary>
        /// <returns>Return different message when current User have or not issues. If current User have issues. List current User issues.</returns>
        public string GetMyIssues()
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            var issues = this.Data.IssuesByUsername[this.Data.CurrentUser.Username];

            if (issues.Count == 0)
            {
                return "No issues";
            }

            string result = string.Join(
                Environment.NewLine, 
                issues.OrderByDescending(x => x.Priority)
                .ThenBy(x => x.Title));
            return result;
        }

        /// <summary>
        /// Get current login user comments
        /// </summary>
        /// <returns>Return different message when current User have or not comments. If current User have comments. List current User comments.</returns>
        public string GetMyComments()
        {
            if (this.Data.CurrentUser == null)
            {
                return "There is no currently logged in user";
            }

            var comments = new List<Comment>();
            this.Data.IssuesById.Select(i => i.Value.Comments)
                .ToList()
                .ForEach(item => comments.AddRange(item));

            var resultComments = comments
                .Where(c => c.Author.Username == this.Data.CurrentUser.Username)
                .ToList();

            var commentsAsStrings = resultComments
                .Select(x => x.ToString());

            if (commentsAsStrings.Count() == 0)
            {
                return "No comments";
            }

            string result = string.Join(Environment.NewLine, commentsAsStrings);
            return result;
        }

        /// <summary>
        /// Search issues with provided tags.
        /// </summary>
        /// <param name="tags">Tags to search</param>
        /// <returns>Return different message when current User have or not issues with given tags.</returns>
        public string SearchForIssues(string[] tags)
        {
            if (tags == null)
            {
                return "There are no tags provided";
            }

            var faundIssues = new List<Problem>();

            foreach (var tag in tags)
            {
                faundIssues.AddRange(this.Data.IssuesTags[tag]);
            }

            if (faundIssues.Count == 0)
            {
                return "There are no issues matching the tags provided";
            }

            var newIssues = faundIssues.Distinct();
            if (!newIssues.Any())
            {
                return "No issues";
            }

            string result = string.Join(
                Environment.NewLine, 
                newIssues.OrderByDescending(x => x.Priority).ThenBy(x => x.Title));
            return result;
        }
    }
}
