namespace Phonebook
{
    using Phonebook.Contracts;

    public class PhoneNumberConvertor : IPhoneNumberConvertor
    {
        public string Convert(string phoneNumber)
        {
            return this.ConvertPhone(phoneNumber);
        }

        private string ConvertPhone(string phoneInput)
        {
            string resultPhone = phoneInput;

            resultPhone = resultPhone
                .Replace(" ", string.Empty)
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace("/", string.Empty)
                .Replace("-", string.Empty);

            if (resultPhone.StartsWith("0"))
            {
                resultPhone = resultPhone.Substring(1);
                resultPhone = "+359" + resultPhone;
            }

            return resultPhone;
        }
    }
}
