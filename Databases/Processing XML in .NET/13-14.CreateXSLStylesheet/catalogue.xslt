<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method='html' version='1.0' encoding='UTF-8' indent='yes' />

  <xsl:template match="/">
    <xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html&gt;
</xsl:text>
    <html>
      <style>
        table{
          border: 1px solid black;
          border-collapse: collapse;
        }

        td, th{
          border: 1px solid black;
          padding: 5px;
        }
      </style>
      <body>
        <h2>Albums</h2>
        <table>
          <thead>
            <tr>
              <th>Name</th>
              <th>Artist</th>
              <th>Year</th>
              <th>Producer</th>
              <th>Price</th>
              <th>Songs</th>
            </tr>
          </thead>
          <tbody>
            <xsl:for-each select="albums/album">
              <tr>
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="artist"/>
                </td>
                <td>
                  <xsl:value-of select="year"/>
                </td>
                <td>
                  <xsl:value-of select="producer"/>
                </td>
                <td>
                  <xsl:value-of select="price"/>
                </td>
                <td>
                  <select>
                    <xsl:for-each select="songs/song">
                      <option>
                        title: <xsl:value-of select="title"/> - duration: 
                        <xsl:value-of select="duration"/>
                      </option>
                    </xsl:for-each>
                  </select>
                </td>
              </tr>
            </xsl:for-each>
          </tbody>
        </table>
        
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>
