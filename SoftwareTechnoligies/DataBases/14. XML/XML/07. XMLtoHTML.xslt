﻿<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <ul>
          <xsl:for-each select="Students/Student">
            <li>
              <div>
                <span>
                  <xsl:value-of select="Name"></xsl:value-of>
                </span> - <span>
                  <xsl:value-of select="Speciality"></xsl:value-of>
                </span>
              </div>
            </li>
          </xsl:for-each>
        </ul>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>