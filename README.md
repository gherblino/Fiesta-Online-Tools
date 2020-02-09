# Fiesta Online Tools
#### A compilation of useful tools for Fiesta Online. I did not have time to finish all of them, so some are still WIP. There are some TODOs left in there, and if you would like to work on them, feel free to create a pull request and I will look at it. That being said, I do hope to see contributions. All small bits help! :)
 
The repository contains the following tools:

## Action Editor
 This editor properly reads (and saves) all the data in .dat files, and allows the user to add/delete actions. Very useful for creating new skills, or adding new animations to classes.
#### To do
 The GUI and shortcuts could get patched up though.

## AID Editor
 This editor allows the users to define areas in maps that can be used/called upon in scripts (look at OX Field for example).
#### To do
 I was going to add a graphical editor like the SHBD editor, but no time.

## Clean Files
 This tool allows the user to clean either a client, or a server. This can be defined in the Configuration.json (which will be automatically generated if the tool is started and there is no Configuration.json in the same directory). The provided Configuration.json also provides an example on how to define nested folders.

## Drop Table Editor
  A handy tool that makes editing Drop Tables significantly easier and faster. Credits to the original writer (Wicious).

## Map Block Editor
 An all-in-one (AID/SBI/SHAB/SHBD/SHMD) map editor. After you select a map folder, it will automatically detect which files exist for the selected map (AID/SBI/SHAB/SHBD/SHMD), and display the tabs accordingly. Functionally it is almost done. 
#### To do
 The only thing that is left is adding the code from the SHBD editor so the SHBD/SHAB (which are effectively the same) part also works. I believe the same goes to the SBI editor, but I am not sure.

## Quest Editor
 A quest editor that has custom filtering. 
#### To do 
 Partially done. The custom filtering was WIP and is only partially implemented. Moreover, the "Mob Info" and "Item Info" sections are not implemented at all. The editor reads all the data properly, but I just did not get around to adding functionality GUI-wise.
 
## SBI Editor
 A graphical editor that allows you to define where doors are positioned in maps. This is very useful for instance dungeons, and scripts in general.
 
## SHBD Editor
 A rather useful editor. Allows the user to define where characters can walk within maps by simply drawing inside the editor. If the drawing is not desired, it also supports importing and exporting from both .png and .shbd files. Functionally done. Rough around the edges in some parts though, but it should not take long to fix that.
 
## SHMD Editor
 A simple SHMD Editor that allows you to define the positions of objects in a map. There is nothing special about this editor, but I made it for completeness sake, and it can be quite useful.

## Sync Files
 A concept for syncing a Shine with a ressystem. Not done at all. Made the GUI and then abandoned it.
