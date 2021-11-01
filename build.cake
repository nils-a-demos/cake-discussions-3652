Task("Default")
.Does(() => {
   Information("Default Task!");
   CakeExecuteScript("./Innerscope/innerbuild.cake");
});

RunTarget("Default");