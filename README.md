# MotiveSitemapper
A utility to create sitemap files for your website.

# Implementation notes
1. With requirements, below, MDOX index numbers will not change once assigned

# Information sources
* S1 - [Build and submit a sitemap](https://support.google.com/webmasters/answer/183668)

# Requirements
## Mandatory
* M1 - Follow published guidelines and cite references here
* M2 - Auto-generate from URL
* M3 - Auto-generate from local folder path
* M4 - Default configuration, so ready to run given just a source of HTML files
* M5 - Generate sitemap of pages
* M6 - Select supported styles from D4-D6, X1-X2
* M7 - Use Motivesoft icon, copyright info
* M8 - Make project entry on [Motivesoft GitHub Page](https://motivesoft.github.io)

## Desirable
* D1 - Settings file to avoid having to specify all options every time
* D2 - Generate sitemap of images
* D3 - Detect and respect canonical version of a page
* D4 - Support XML format, see [sitemap.org](https://www.sitemaps.org/protocol.html)
* D5 - Support text format
  * D5.M1 - One URL per line of a text file
  * D5.M2 - UTF8 encoding
  * D5.M3 - No content other than URLs
  * D5.M4 - File with .txt extension
* D6 - Support sitemap of sitemaps

## Optional
* O1 - Generate sitemap of videos
* O2 - Suggest line for robots.txt, e.g. "Sitemap: http://example.com/sitemap.xml"

## Excluded
* X1 - No support for RSS, mRSS, Atom 1.0 blog feed formats
* X2 - No support for Google Sites

# Test cases
* T1 - 