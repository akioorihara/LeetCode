using System;
namespace Problem21
{
	public class Solutions
	{
		public Solutions()
		{
		}

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            // Validations
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            var newHead = new ListNode(0); // Creating this dummy node ease the logic
            var runnerHead = newHead;        // This is the runner node

            while (list1 != null && list2 != null)
            {
                if (list1.val >= list2.val)
                {
                    runnerHead.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    runnerHead.next = list1;
                    list1 = list1.next;
                }

                runnerHead = runnerHead.next;
            }

            // Simply add the 'leftover' from the while loop at the end 
            if (list1 != null) runnerHead.next = list1;
            if (list2 != null) runnerHead.next = list2;

            return newHead.next;
        }


    }
}

