MP3Scrubber recursively scours a folder and removes files created before a certain date/time and any empty directories. However, it will ignore the following:
	* Directories named _IGNORE
	* Files named folder.jpg

Additionally, the program can be used to "tilt" filenames making them suitable for transcoding into the same directory. This renaming process helps prevent filename conflicts with the newly trancoded files.

For example...
	myfile.mp3
...would become...
	myfile-897123123.mp3

Finally, if you're not ready to actually scrub the files/folders, you can run the operation in "simulate" mode. This will list everything that *would* have been deleted, but will not actually delete it.