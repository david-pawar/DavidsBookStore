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


     November 21 

0450 updated Category/Index.cshtml, Category/Upsert.cshtml, I had contoller folder in Customer folder, but I was not getting any result,
      I moved that back to root directory, S
      still not getting Category class displayed, but I am doing further work.

1304  I did not move the controllers folder in Customer folder in part1, that was error, I did that and now can see index file without error, but category.cshtml is not displaying

1333  I deleted category.js and related files, and created all stuff from first square.

FINALLY, I AM HAPPY. I read alot of slides today, from part slides to to today's slides. But, that mundane work paid off.

1348  added IActionResult upsert in CategoryController.cs

1425  ERROR : everything is done okay, but when i click on create new category, it shows error 

"InvalidOperationException: The model item passed into the ViewDataDictionary is of type 
'DavidsBooks.Models.Category', but this ViewDataDictionary instance requires a model item of type 'System.Int32'."

2023-11-24  

1010   all application is working correctly, before I did not added the IActionResult GetAll in CategoryController.js 
FIX: now I added that code, Now app is working good

1013    review further steps, which I done before, I found a typo: rather than writing category.js I wrote Category.js
1016   ERROR    I am creating category, but it does not show in category list

there are more stuff do , I guess, if I want to add category

Added IActionResult Delete in CategoryController.cs , 
in Upsert.cshtml  changed @if (Model.Id != null)    ->   @if (Model.Id != 0)   on line 12

1026   added this code   onclick=Delete("/Admin/Category/Delete/${data}")    in Category.js on line 23

1230 added delete function in category.js

slides end, hope this will work and dont have to read all slides from beginning.

Hurayyyyyyy!   - it worked, amazing





                                                       NOV 24  -   FINALLY ON Part 3



SECTION-1 

1039   I have already added CoverType.cs in the project
       I have already added CoverTypeRepository.cs and ICoverTypeRepository.cs

1042 added CoverTypeRepository.cs and ICoverTypeRepository.cs  in UnitOfWork and IUnitOfWork, but it showing a little error

ERROR in UNITOFWORK 

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS1729	'CoverTypeRepository' does not contain a constructor that takes 1 arguments	DavidsBooks.DataAccess	
1057, some error get fixed but, one error still persist

in UnitOfWork.cs: 
Error	CS1729	'CoverTypeRepository' does not contain a constructor that takes 1 arguments	

fix above error by adding constructor with one parameter

1109 : error - Cannot implicitly convert type 'DavidsBooks.DataAccess.Repository.CoverTypeRepository' 
to 'DavidsBooks.DataAccess.Repository.IRepository.ICoverTypeRepository'. An explicit conversion exists (are you missing a cast?)

1113 going to do IUnitOfWork and UnitOfWork parts again

1132 ERROR CAUSE: I did not perform all steps, did not added covertype controller and view,
1310 all steps has been performed - created ICoverTypeRepository, Updated IUnitOfWork.cs and UnitOfWork, create CoverTypeRepository and 
     ICoverTypeRepository.cs 

     create migraation and updated database - 20231124175650_CoverTypeToTheDatabase.cs    ========NAME

1331  added CoverType link in _Layout.cshtml on line 32 

1331  added CoverTypeController.cs   - I wrote it before, to save my work i copied that somewhere, and now I just copied again from there

1336  create CoverType folder in View, and added Index.cshtml file in it

1340  added upsert.cshtml file in it

1343  added delete CoverType in API CALLS
1354 forgot to add CoverType.js , added now, and its functional and working now

1401  added Product.cs class in Project,
      updated ApplicationDbContext

1414  20231124191349_addProductToDb  added migration and update database   ================================================NAME
1415  In SOE, review the new products table and its there with other tables

1415 made title ISBN and author required fields

1416 20231124191555_addValidationToProduct    ==============================================NAME
     and updated database


1549  created ProductController.cs
1604 installed Microsoft.AspNetCore.Mvc.ViewFeatures

1644 created productController.cs and Product.js

1657   on section -3 

1658 created upsert.cshtml

there is asked to created account on tiny.clound to add text area, I created account but I do not know further step ,so copied textarea
 provided in slides.

1705 forgot to created ProductVM,cs got error so create now,

1717 ran the application and product option has a weird error, that it is not adding price 

ERROR: DataTables warning: table id=tblData - Requested unknown parameter 'price' for row 0, column 2. For more information about this error, please see http://datatables.net/tn/4

FIX :    there was typo in Product.js  , I wrote price instead on listPrice on line 16

new error : i am unable to see category field's data 

ERROR: DataTables warning: table id=tblData - Requested unknown parameter 'category.Name' for row 0, column 4. For more information about this error, please see http://datatables.net/tn/4

FIX:  I wrote category.Name instead of category.name  (if my memory serves accurately, category.Name was written in slides)
anyways, data is showing correctly. I am happy, finally its done

2023-11-27

1424   adding cover types and products to application.
    
WRONG FUNCTIONING =  when I go to add product, when I dropdown the select  the covertype it shows category list, FIX it in Admin/Views/Product/Upsert.cshtml 

1438   now realized, image and discription sections are not showing. I think if I am adding image and description , they should be displayed.

1703   gonna try to display products on the home page.

did - added product's link and remove link of home page from nav bar, that did not work, I want when I open the app, that products displayed.

2105 dont know where API CALLS disappear from my all three controller classes, adding again in them from old commits

