using System.Collections.Generic;

namespace UniclassAPIClient.Models
{
    public class ClassificationNode
    {
        public string Notation { get; set; }
        public string Title { get; set; }
        public List<ClassificationNode> Children { get; set; }
    }
}
