// using System;

// namespace examples
// {
//     public class SinglyLinkedListNode
//     {
//         public int data { get; set; }
//         public SinglyLinkedListNode next { get; set; }

//         public SinglyLinkedListNode(int d)
//         {
//             data = d;
//         }
//     }

//     public class SinglyLinkedList
//     {
//         public SinglyLinkedListNode head;
//         public SinglyLinkedListNode[] items = new SinglyLinkedListNode[1000];

//         public void InsertNode(int data)
//         {
//             if (head == null)
//             {
//                 head = new SinglyLinkedListNode(data);
//             } else {
//                 items[items.Length - 1] = new SinglyLinkedListNode(data);
//             }
//         }

//         static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {
//             if (position == 0)
//             {
//                 var temp = new SinglyLinkedListNode(head.data);
//                 head = new SinglyLinkedListNode(data);
//                 head.next = temp;
//                 return head;
//             }
//             var node = head.next;
//             var previous = head;
//             var i = 1;
//             while(node != null)
//             {
//                 if (position == i) {
//                     SinglyLinkedListNode temp = new SinglyLinkedListNode(node.data);
//                     temp.next = node.next;
//                     node.data = data;
//                     node.next = temp;
//                 }
//                 node = node.next;
//                 i += 1;
//             }

//             return head;
//         }
//     }

//     public class lists
//     {
//         public static void linkedListExample()
//         {
//             SinglyLinkedList llist = new SinglyLinkedList();
//             int llistCount = Convert.ToInt32(Console.ReadLine());
//             for (int i = 0; i < llistCount; i++) {
//                 int llistItem = Convert.ToInt32(Console.ReadLine());
//                 llist.InsertNode(llistItem);
//             }

//             int data = Convert.ToInt32(Console.ReadLine());
//             int position = Convert.ToInt32(Console.ReadLine());

//             SinglyLinkedListNode llist_head = llist.insertNodeAtPosition(llist.head, data, position);

//             var node = llist_head;
//             while(node.next != null)
//             {
//                 System.Console.WriteLine(node.data);
//                 node = node.next;
//             }
            
//             Console.ReadLine();
//         }
//     }
// }