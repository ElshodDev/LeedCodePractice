namespace LeedCodePractice.Examples.remove_duplicates_from_sorted_lists
{
    public class remove_duplicates_from_sorted_list
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;

            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    // Keyingi nodega o'tamiz
                    current = current.next;
                }
            }

            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
