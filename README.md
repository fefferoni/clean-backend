## Solution architecture
The solution is architected in dependancy strategic way. All dependencies are pointing toward the center project called Domain. The solution can be seen as separated into layers (aka Onion architecture). Dependencies on each layer can only point inwards. This ensures that we don't have any reference problems later. It also ensures that the system is testable, especially any business rules in the domain/application layer. This will always be true no matter if we for example change any of the external dependencies of the system like the data storage provider.

Inspired by Steve Smith's sample (aka ardalis) https://github.com/ardalis/CleanArchitecture

## Mediater pattern
The mediator pattern in it's simplicity is a way of creating communication between objects over a loose coupling, that is, they do not need to referenced.

In the API project I demonstrate a quite common (and imho) very nice way of using the mediator pattern to make my controllers clean and tidy. I accomplish this with the help of a library called MediatR by Jimmy Bogard.  (https://github.com/jbogard/MediatR).

As you can see, the mediator keeps the controllers really clean and we do not need to reference multiple handlers, services or repositories. We only need a reference to our mediator and we can rely on the mediator to pass on our query or command to the correct handler. And everytime we need to add, change or remove a handler we do not need to change the controller. 

Besides helping to keep the implementation clean and loosely coupled the MediatR library also has another feature called behaviors. We can add a pipeline around our handlers to decorate them with behaviors. As an example I have added a validation behavior which makes every request, of type CreateItemCommand, passing through the Mediators Send method being validated according to my custom validation rules.

## CQRS pattern
As you can see in this sample solution I have separated the queries from the commands. This is what the CQRS pattern primarily is about. By separating these it allows the models and handlers to be more specific about their task and avoiding the need to have both query and update logic/properties in the same classes. This approach gives us several benefits such as:
- Better isolation = easier testing
- Better isolation = easier to do potential up-/down scaling or optimizations for better performance
- Good foundation for a micro services architecture where we might communicate between services with events (good in DDD where we use domain events)
- More task based commands/queries which is preferred in DDD (eg. instead of returning a database model we return an aggregate root)

It is worth mentioning that CQRS naturally adds a bit of additional complexity to a solution since in some cases you will have two or more models instead of one. This is not really the case in this rather small sample solution though sine it does not have very much complexity yet =)
