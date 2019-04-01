<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html" version="4.0"
encoding="UTF-8" indent="yes"/>
<xsl:template match="/">
  <html>
  <body>
  <h2>Environment</h2>
	<table border="1">
		<tr bgcolor="#B3B6B7">
			<th>Platform</th>
			<th>Machine Name</th>
			<th>User</th>
			<th>Domain</th>
		</tr>
		<xsl:for-each select="/test-run/test-suite/environment">
		<tr>
			<td><xsl:value-of select="@platform"/></td>
			<td><xsl:value-of select="@machine-name"/></td>
			<td><xsl:value-of select="@user"/></td>
			<td><xsl:value-of select="@user-domain"/></td>
		</tr>
		</xsl:for-each>
	</table>
	
	<h2>Date/Duration</h2>
	
	<table border="1">
		<tr bgcolor="#B3B6B7">
			<th>Start-Time</th>
			<th>End-Time</th>
			<th>Duration</th>
		</tr>
		<xsl:for-each select="/test-run">
		<tr>
			<td><xsl:value-of select="@start-time"/></td>
			<td><xsl:value-of select="@end-time"/></td>
			<td><xsl:value-of select="@duration"/></td>
		</tr>
		</xsl:for-each>
	</table>
	
	<h2>Test Run Summary</h2>
	
	<table border="1">
		<tr bgcolor="#B3B6B7">
			<th>Test Count</th>
			<th>Passed</th>
			<th>Failed</th>
			<th>Skipped</th>
			<th>Inconclusive</th>
		</tr>
		<xsl:for-each select="/test-run">
		<tr>
			<td><xsl:value-of select="@total"/></td>
			<td><xsl:value-of select="@passed"/></td>
			<td><xsl:value-of select="@failed"/></td>
			<td><xsl:value-of select="@skipped"/></td>
			<td><xsl:value-of select="@inconclusive"/></td>
		</tr>
		</xsl:for-each>
	</table>

	<h2>Results</h2>
    <table border="1">
      <tr bgcolor="#B3B6B7">
	    <th>Id</th>  
        <th>Class Name</th>
        <th>Test Name</th>
        <th>Status</th>
        <th>Duration</th>
      </tr>
      <xsl:for-each select="test-run/test-suite/test-suite/test-suite/test-case">
      <tr>
        <td><xsl:value-of select="@id" /></td>
		
<xsl:choose>
        <xsl:when test="starts-with(./@classname, 'NUnitTests.Db')">
          <td bgcolor="#FCF3CF">
          <xsl:value-of select="@classname"/></td>
        </xsl:when>
		<xsl:when test="starts-with(./@classname, 'NUnitTests.P')">
          <td bgcolor="#F0E68C">
          <xsl:value-of select="@classname"/></td>
        </xsl:when>
        <xsl:otherwise>
          <td bgcolor="#A9CCE3">
          <xsl:value-of select="@classname"/></td>
        </xsl:otherwise>
      </xsl:choose>		
		
		
        <td><xsl:value-of select="@name" /></td>
        
            
<xsl:choose>
        <xsl:when test="starts-with(./@result, 'F')">
          <td bgcolor="#E74C3C">
          <xsl:value-of select="@result"/></td>
        </xsl:when>
		<xsl:when test="starts-with(./@result, 'Sk')">
          <td bgcolor="#F9A11A">
          <xsl:value-of select="@result"/></td>
        </xsl:when>
		<xsl:when test="starts-with(./@result, 'Inc')">
          <td bgcolor="#F9A11A">
          <xsl:value-of select="@result"/></td>
        </xsl:when>
        <xsl:otherwise>
          <td bgcolor="#2ECC71">
          <xsl:value-of select="@result"/></td>
        </xsl:otherwise>
      </xsl:choose>


        <td><xsl:value-of select="@duration" /></td>
      </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>

