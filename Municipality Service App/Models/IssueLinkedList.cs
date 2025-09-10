using static System.Net.WebRequestMethods;

namespace Municipality_Service_App.Models
{
    public class IssueNode
    {
        public IssueViewModel Data { get; set; }
        public IssueNode Next { get; set; }

        public IssueNode(IssueViewModel data)
        {
            Data = data;
            Next = null;
        }
    }

    public class IssueLinkedList
    {
        private IssueNode head;

        public void AddIssue(IssueViewModel issue)
        {
            var newNode = new IssueNode(issue);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
    }
}


//<!-- Referencing -->
//<!--Microsoft Learn, 2025. LinkedList<T> Class [Online]. Available at:<https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-9.0> [Acessed on 01 September 2025]-->
//<!--wheretostay,2020. Durban Beachfront Accommodation[Electronic Print]. Available at:<https://www.wheretostay.co.za/town/durban-beachfront-cbd/accommodation> [Acessed on 05 September 2025]-->
//<!--IStock,2019. Durban Beachfront [Electronic Print]. Available at:<https://www.istockphoto.com/search/2/image-film?phrase=durban+beach> [Acessed on 05 September 2025]-->
//<!--Facebook, 2012. EThekwini Municipality [Electronic Print]. Available at:<https://www.facebook.com/eThekwiniM/> [Acessed on 05 September 2025]--><!-- Referencing -->
