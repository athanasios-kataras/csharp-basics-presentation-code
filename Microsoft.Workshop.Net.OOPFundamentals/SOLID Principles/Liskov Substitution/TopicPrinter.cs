using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Liskov_Substitution
{
    public abstract class Topic
    {
        public abstract string Content { get; set; }
        public void Print() { }
    }

    public class NewsTopic : Topic
    {
        public override string Content { get; set; }
    }

    public class SienceTopic : Topic
    {
        public override string Content { get; set; }
    }

    public class TopicPrinter
    {
        public void PrintTopics(List<Topic> topics)
        {
            foreach (var topic in topics)
            {
                if (topic is NewsTopic)
                {
                    printNewsTopic(topic as NewsTopic);
                }
                printTopic(topic);
            }
        }

        public void PrintTopics1(List<Topic> topics)
        {
            foreach (var topic in topics)
            {
                topic.Print();
            }
        }

        private void printTopic(object topic)
        {
            throw new NotImplementedException();
        }

        private void printNewsTopic(NewsTopic newsTopic)
        {
            throw new NotImplementedException();
        }
    }
}