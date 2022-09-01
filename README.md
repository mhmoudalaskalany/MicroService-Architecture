# MicroService-Architecture
Microservices Architecture With Event Sourcing And (AMQP) using Rabbit MQ And Api Gateway Using Oclet


# Solution Structure

# Employee Service:
Handle Employees CRUD Operations

# Task Service:
Handle Tasks CRUD Operations And Assigning Tasks On Employees


# API Gateway

handle front end access to backend services using oclet gateway


# AMQP ( Advanced Messaging Queue Protocol)

Messaging queue using Rabbit MQ to handle events between services

#  Example:

- Employee Service : handle update operation  on employee data after that it publishan event to a queue
- Task Service : subscribe to that queue and consume the events from the queues and do what is required to update employee data who is assigned to task


# Used Technologies

- .Net Core 6
- Ocelt Gateway
- Rabbit MQ

# Running The Solution

- Pull Rabbit MQ Image using docker and run it using this command (docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.10-management) (note: you can use local windows installation)
- Change solution settings to start multiple projects and set them in order (Employee Service , Task Service , Api Gateway)
