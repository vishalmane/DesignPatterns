using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDocument document = new MyDocument(new ReadOnly());
            document.Update("test");
            document.ChangeState(new ReadWriteOnly());
            document.Update("test");
            document.ChangeState(new Locked());
            document.Update("test");
        }
    }

    public class MyDocument
    {
        private DocumentState State;
        public MyDocument(DocumentState state)
        {
            State = state;
        }

        public void ChangeState(DocumentState state)
        {
            State = state;
        }

        public void Update(string text)
        {
            State.HandelUpdate(text);
        }

    }
    public abstract class DocumentState
    {
        public abstract void HandelUpdate(string text);
    }

    public class ReadOnly : DocumentState
    {
        public override void HandelUpdate(string text)
        {

        }
    }
    public class ReadWriteOnly : DocumentState
    {
        public override void HandelUpdate(string text)
        {

        }
    }
    public class Locked : DocumentState
    {
        public override void HandelUpdate(string text)
        {

        }
    }
}
