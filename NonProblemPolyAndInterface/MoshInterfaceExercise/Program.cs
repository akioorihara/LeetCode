/*
 * Excercise: Design a workflow engine
 * 
 * This is the exercise provided by Mosh - Intermediate learning exercise from Mosh
 * This exercise is about learning how to use interface in C# 
 * 
 */
using MoshInterfaceExercise;

//Instantiate the object and call the constructor 
var workflowEngine = new WorkFlowEngine();


//register some workflows

// 1. Upload a video to a cloud storage.
workflowEngine.Register(new UploadVideo("C:\\current\\directory"));

workflowEngine.Register(new EmailNotifications(new Email("test@test.com", "test subject")));

// 2. Call a web service provided by a
//third-party video encoding service to tell them you have a
//video ready for encoding.
workflowEngine.Register(new TextNotifications());
workflowEngine.Register(new ValidateAddress());


// To run and execute all register job(s) 
workflowEngine.Run();



