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

example:

1-Employee Service : handle update operation  on employee data after that it publishan event to a queue
2-Task Service : subscribe to that queue and consume the events from the queues and do what is required to update employee data who is assigned to task


# Used Technologies

.Net Core 3.1
Ocelt Gateway
Rabbit MQ
