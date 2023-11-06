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

2219 changed the default project and no more red lines, I chose the 'AddDefaultIdentityMigration' as the name of the migration
2223 ran update-database    command
2224 reviewed the tables in SQL server object explorer

2229 run application, and did not encounter with any error.
2241 created the Category.cs file, and edit as instructed
2245 added new migration 'AddCategoryToDb'

2249 updated ApplicationDbContext.cs 

2255 tried some command by searching googli like Remove-Migration, but did not work, so deleted the migration file from folder mannually.
      HOPE it is right way

2256 run the command "add-migration AddCategoryToDb"

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

