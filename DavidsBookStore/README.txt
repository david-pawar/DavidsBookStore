2023-10-29 Started project, but facing error in creating git repo, tried different ways, but its not getting on remote server.

Created project and repo on college's pc and clone the repo and worked on that thing

oct 30 3pm - created project and uploaded to github on college's pc
created project and allowed individual user account, and enabled razor runtime compilation
modified startup.cs file and commented out a piece of code
Read all the review slides

added bootswatch theme named Darkly
remove .min from bootstrap link
changed nav bar bootstrap css

replaced site.cs 's code

added additional provided css and js links on layout file


oct 31 0640 right click on solution icon to create new project but not getting option to create a new project

ERROR - write code for dropdown button, dropdown was not working, searched bootstrap dropdown and got the solutions
changed dropdown with content management

new project option is showing, it was not showing because application was running. close the app and created all projects




November 5, 2023  - started Assignment-2 =============================





2209 downloaded the provided guiding ppsx

2210 first cleaned the solution and then build the solution - I am glad to see 4 succeeded messaged while doing both

2217 ran the migration, and got the same red message which is shown in ppsx, however, did  not get yellow color warning or depracated version,
     and then checked my versions of packages, and they are installed with latest version 5

2219 changed the default project and no more red lines, I chose the 'AddDefaultIdentityMigration' as the name of the migration   ===========name
2223 ran update-database    command
2224 reviewed the tables in SQL server object explorer

2229 run application, and did not encounter with any error.
2241 created the Category.cs file, and edit as instructed
2245 added new migration 'AddCategoryToDb'                 ============name
20231106035726_AddCategorytoDb

2249 updated ApplicationDbContext.cs 

2255 tried some command by searching googli like Remove-Migration, but did not work, so deleted the migration file from folder mannually.     
      HOPE it is right way

2256 run the command "add-migration AddCategoryToDb"              ==============name

November 6

1321 modified IRepository.cs file
1347 was writing Repository.cs file, then saw the files have been provided, copied them and edit, hope I did right

1403 in CategoryRepository.cs facing an error in line where I declare public class ______;
 ERROR : Error	CS0307	The namespace 'DavidsBooks.DataAccess.Repository' cannot be used with type arguments	DavidsBooks.DataAccess	
         C:\Users\david\Source\Repos\DavidsBookStore\DavidsBooks.DataAccess\Repository\CategoryRepository.cs	12	Active

FIX = change keyword from class to interface of IRepository

1418 still coding in CategoryRepository.cs and in ICategoryRepository.cs , some error are still persisting
1430 delete all category repository related file and gonna do part 2 from beginning

1435 I added two folder in DataAccess.csproj, which I did not added before.
1451 in ppsx, it is written that modify the code but not to copy the whole repo.cs file. 

1531 created ICategoryRepository.cs, and edited it as instructed
implement interface
and updated     public void update's code 
1536 ran the project and it ran withour error,

1617 encounter with an error in SP_Call.cs 
 ERROR

 1631 update sp_call.cs code

1650 created UnitOfWork.cs files
1656 edited startup.cs file
1721 fixed some erroe, before did not added th #endregion, added now


november 14
created categoryController.cs was getting error, now solved that, files were get created in wrong folder, did all wrong work after that.
created categorycontroller and index in admin/category/index.cshtml file, pasted HTML code in the files, but interface is not showing

nov 20 

I did work before today, but after commiting did not push that and project was not running, so closed visual studio and recloned project, and 
work was not here

anyways, I remember it just have to again

1152 - My project is not producing desired results, So reviwing it
In slide 4 of part-2, at the end , it say update the database and confirm new table "category " via SQL SOE .
I guess I missed that step as my readme file has saying nothing about this step

[Missed step] - on slide-6, it says to add a line in data.dataacess.csproj 
added now 
<Folder Include="Repository\IRepository\" />

1206 - slide 7 says to modify code to create the constructors and dependency injection
see assignment-2 folder

now, if compare code of repository,cs from folder and mine project one, both are different
ref. line 61 of README

1211 my current repository.cs has two two functions two remove, two GetFirstOrDefault, etc.
added Repository.cs which is provided by folder in my project, so far no error

1258 recreated IUnitOfWork and UnitOfWork, bcs it was showing some error

fixed some errors coming in adding service in Startup.cs, fixed that, I removed the extension of IUnitOfWork. then added back.

1340 : I did all as instructed in ppsx,  but I am not gettig that interface that should be there by coping in Area\View\Index.cshtml;
 the categoryList and add new category interface.

1404 : now when i run application, nothing happen, noting displayed.

     : normal page is opening, added category link in dropdown but Category link is not opening. I am doing further work, its been long time 
     fixing this error,
