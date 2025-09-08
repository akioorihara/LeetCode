/*
 * 
 * This is a practice to use Interface and Polymorphism  
 * This practice comes from Udemy - Code with Mosh 
 * 
 */

using InterfacesAndPolymorphism;

var encode = new VideoEncode();

encode.Register(new MailNotification());
encode.Register(new TextNotification());

encode.Encode(new Video());

