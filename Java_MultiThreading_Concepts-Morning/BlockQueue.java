import java.util.LinkedList;

public class BlockQueue {
    public static void main(String[] args)
            throws InterruptedException
    {
        // Object of a class that has both put()
        // and get() methods
        final PC pc = new PC();

        // Create producer thread
        Thread t1 = new Thread(new Runnable() {
            @Override
            public void run()
            {
                try {
                    pc.put();
                }
                catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        });

        // Create consumer thread
        Thread t2 = new Thread(new Runnable() {
            @Override
            public void run()
            {
                try {
                    pc.get();
                }
                catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        });

        // Start both threads
        t1.start();
        t2.start();

        // t1 finishes before t2
        t1.join();
        int con_count =7;//no. of consumer threads
        for(int i=0;i<con_count;i++)t2.join();
    }

    // This class has a list, producer (adds items to list
    // and consumer (removes items).
    public static class PC {

        // Create a list shared by producer and consumer
        // Size of list is 2.
        LinkedList<Integer> list = new LinkedList<>();
        int capacity = 4;

        // Function called by put thread
        public void put() throws InterruptedException
        {
            int value = 0;
            while (true) {
                synchronized (this)
                {
                    // producer thread waits while list
                    // is full
                    while (list.size() == capacity){
                        System.out.println("Queue is full. No task is already taken by any of the consumer.");
                        wait();}

                    System.out.println("Producer produced-"
                            + value);

                    // to insert the jobs in the list
                    list.add(value++);

                    // notifies the consumer thread that
                    // now it can start consuming
                    notify();

                    // makes the working of program easier
                    // to understand
                    Thread.sleep(1000);
                }
            }
        }

        // Function called by get thread
        public void get() throws InterruptedException
        {
            while (true) {
                synchronized (this)
                {
                    // get thread waits while list
                    // is empty
                    while (list.size() == 0) {
                        System.out.println("Queue is empty. There is no task present in the Queue");
                        wait();
                    }
                    // to retrive the ifrst job in the list
                    int val = list.removeFirst();

                    System.out.println("Consumer consumed-"
                            + val);

                    // Wake up producer thread
                    notify();

                    // and sleep
                    Thread.sleep(1000);
                }
            }
        }
    }
} 
