# **PCL Localizer**.
*A simply cross platform alternative to Resx.*
[Follow this guide step by step!](http://markjackmilian.net/blog/pcllocalizer-step-by-step/)

#*Quick Start*
*Add [Pcl.Localizer](https://www.nuget.org/packages/Pcl.Localizer/) nuget package to all projects that will use localization.*
In your entry point app call:

	PclResMan.SetLanguage(yourlanguage);

**How generate resources:**
You can use PclLocalization.Console or add [Pcl.Localization.Generator](https://www.nuget.org/packages/Pcl.Localizer.Generator) nuget package to the project that will contains the resources.
The nuget will create a folder called Loc with 3 files:

 1. The Console app
 2. A txt example file 
 3. A bat for generate resource

When you run the bat the txt file will be parsed and a cs file will be generate..now simply include the new cs file to your project. You can call your resource like this:

	MyLoc.Test

For help about console call:

	PclLocalizer.Console.exe -h

Example for generate:

	PclLocalizer.Console.exe -f example.txt -d MyLoc.cs -n MyNameSpace -c MyLoc -s ;
where

 - -f is the input file
 - -d is the destination file
 - -n is the namespace for generated class
 - -c is the name of the generated class
 - -s is the separator

For add "Run batch" from Visual Studio context menu follow [this](http://stackoverflow.com/questions/5605885/how-to-run-a-bat-from-inside-the-ide) guide.

##Follow Me

 - Twitter: [@markjackmilian](https://twitter.com/markjackmilian)
 - MyBlog: [markjackmilian.net](http://markjackmilian.net/blog)
 - Linkedin: [linkedin](https://www.linkedin.com/in/marco-giacomo-milani)

##License
Licensed under Apache see license file.