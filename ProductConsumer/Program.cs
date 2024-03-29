﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
var factory = new ConnectionFactory()
{
    HostName = "localhost",
};
var connection = factory.CreateConnection();
var channel = connection.CreateModel();
var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, args) =>
{
    var body = args.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine("Product message received:"+message);

};
channel.BasicConsume(queue: "Product", autoAck: true, consumer: consumer);

Console.WriteLine("consuming started");
Console.ReadLine();