#FSync

**This is working prototype.**

**File synchronization application**

* The application detects new or changed files in the specified folder and copies them to the destination folder. 
* The files can be compressed into an archive file and then uploaded to the destination folder. 
* The app keeps track of which files have been transferred.

**Parameters:**
* **FSync.exe [-r] [-f] [-e list] [-z name_suffix] [-i file] [-SRCDIR destination] [-DESTDIR destionation]**

* **-r** - it synchronizes files in subdirectories, into a destination folder creates a single directory, unless you use the parameter -z
* **-f** - permit overwrite the target file if it is not specified, the files in the destination folder exists, will be skipped
* **-z** - all found files to synchornizace are compressed into a single zip file, zip file name begins with timestamp and ends with the specified suffix, eg .: 20162011233100_images.zip for a specified suffix _images
* **-e** - list of allowed file extensions, if not specified, transfers all files, various suffixes are separated by a comma, for example: „-e pdf, doc, jpg, gif, png“
* **-i** - file path where the program stores the information already transferred files, if the file is not specified, are always transferred all the files again if it is an invalid path to the file (for example folder does not exist) and the transmission fails, for example: „-i index .txt“

**Example cmd**
* FSync.exe -r -f -i "index.txt" -SRCDIR "C:\directory\\\" -DESTDIR "C:\directoryDEST\\\"