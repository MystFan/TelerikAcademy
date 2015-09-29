<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <style>
        table {
          font-size: 20px;
          text-align: center;
        }

        th, td {
          padding: 5px;
        }
      </style>

      <body>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <thead>
            <tr bgcolor="#EEEEEE">
              <th>Student</th>
              <th>Gender</th>
              <th>Birth Date</th>
              <th>Phone</th>
              <th>E-mail</th>
              <th>Course</th>
              <th>Specialty</th>
              <th>Faculty #</th>
              <th>Exams</th>
            </tr>
          </thead>
          <tbody>
            <xsl:for-each select="students/student">
              <tr>
                <td>
                  <xsl:value-of select="name" />
                </td>
                <td>
                  <xsl:value-of select="sex" />
                </td>
                <td>
                  <xsl:value-of select="birth-date" />
                </td>
                <td>
                  <xsl:value-of select="phone" />
                </td>
                <td>
                  <xsl:value-of select="e-mail" />
                </td>
                <td>
                  <xsl:value-of select="course" />
                </td>
                <td>
                  <xsl:value-of select="specialty" />
                </td>
                <td>
                  <xsl:value-of select="faculty-number" />
                </td>
                <td>
                  <xsl:for-each select="exams/exam">
                    <div>
                      <strong>
                        <xsl:value-of select="exam-name"/>
                      </strong> /
                      endorsement: <xsl:value-of select="endorsement"/> /
                      score: <xsl:value-of select="score"/>
                    </div>
                  </xsl:for-each>
                </td>
              </tr>
            </xsl:for-each>
          </tbody>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>