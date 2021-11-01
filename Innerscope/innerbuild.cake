Task("InnerTask")
 .Does(()=> 
 {
     Information("This is the inner Task");
 });

 RunTarget("InnerTask");