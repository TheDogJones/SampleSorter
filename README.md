# SampleSorter
A small Windows app for easily organizing audio samples in bulk.

![Screenshot](./screenshot.png?raw=true "SampleSorter")

Download here: https://drive.google.com/file/d/1AOaaL7PKJFexbU1fqyN8udDc4gscYyKC/view

Instructions:

1) Select a directory containing the samples you want to organize. The application searches recursively, so it will find all .wav files in that directory and all subdirectories.

2) Select a file action.  
  -Move file: Moves the .wav to the new, organized folder, deleting the original.  
  -Copy file: Makes a copy of the .wav to the new folder.  
  -Create hard link to file: Creates a separate directory path to the same file. This creates the appearance of copying the file without taking up any extra disk space. Learn more about hard links here: https://docs.microsoft.com/en-us/windows/desktop/fileio/hard-links-and-junctions
  
3) The first sample found will automatically be loaded. Click the button containing the filename of the sample to listen to it. The buttons below will place the sample into a directory named according to the text on the button.  
  -The buttons that say (set) are blank. Clicking on them will open a prompt to create a custom folder.  
  -Right clicking on any button will also open a prompt to rename it. This will not affect previously sorted samples.  
  -The "Skip" button will continue with no action.  
  -WARNING: CLICKING THE "GARBAGE" BUTTON WILL DELETE THE SAMPLE FOREVER. DO NOT CLICK THIS UNLESS YOU ARE POSITIVE YOU WILL NEVER WANT IT.
  
4) After clicking a button to file away a sample, the next one will be automatically be loaded. The process is designed to be streamlined so you can very quickly go through a lot of samples without much effort.

5) Click the exit button when you get bored.
