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
workflowEngine.Register(new EmailNotifications());
workflowEngine.Register(new TextNotifications());
workflowEngine.Register(new ValidateAddress());


// To run and execute all register job(s) 
workflowEngine.Run();



