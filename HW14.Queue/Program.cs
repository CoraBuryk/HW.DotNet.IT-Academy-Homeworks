using HW14.Queue;
using static HW14.Queue.CustomQueueT;
{
    QueueDT();
    QueueObject();
    QueueGeneric();
}
static void QueueDT()
{
    Console.WriteLine("DateTime:");
    CustomQueueDateTime queue = new CustomQueueDateTime(10);
    Random gen = new Random();
    DateTime start = new DateTime(1800, 1, 1);
    for (int i = 0; i < 15; i++)
    {
        queue.Enqueue(start.AddDays(gen.Next(80000)));
    }
    for (int i = 0; i < queue.Size; i++)
    {
        start = queue.Dequeue();
        Console.WriteLine(start);
    }
}
static void QueueObject()
{
    Console.WriteLine("Object:");
    CustomQueueObject queue = new CustomQueueObject(3);
    object start;
    queue.Enqueue(13);
    queue.Enqueue("Hello");
    queue.Enqueue('h');
    queue.Enqueue(2.34567);
    for (int i = 0; i < queue.Size; i++)
    {
        start = queue.Dequeue();
        Console.WriteLine(start);
    }
}
static void QueueGeneric()
{
    Console.WriteLine("Generic:");
    CustomQueue<Car> queue = new CustomQueue<Car>();
    for (int i = 0; i < 10; i++)
    {
        queue.Enqueue(new Car());
    }
    Console.WriteLine(queue.Peek());
    for (int i = 0; i < queue.Size; i++)
    {
        Console.WriteLine(queue.Dequeue());
    }
}