using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] array;
        private int head;
        private int tail;

        public Queue()
        {
            array = new T[DefaultCapacity];
            head = 0;
            tail = 0;
        }

        public int Count
        {
            get
            {
                if (head <= tail)
                    return tail - head;
                else
                    return tail + (array.Length - head);
            }
        }

        public void Clear()
        {
            array = new T[DefaultCapacity];
            head = 0;
            tail = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull())           //가득차서 배열 새로 늘려줌 
            {
                Grow();
            }

            array[tail] = item;
            MoveNext(ref tail);
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            T result = array[head];
            MoveNext(ref head);
            return result;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return array[head];
        }

        private void Grow()
        {
            int newCapacity = array.Length * 2;     //2배로 늘림
            T[] newArray = new T[newCapacity];
            if (head < tail)   // h . . . t   h ~ t 까지
            {
                Array.Copy(array, head, newArray, 0, tail);
            }
            else //헤드가 더 뒤에있는경우 t . . h 
                 // 헤드부터 끝까지 0부터 t 까지
            {
                Array.Copy(array, head, newArray, 0, array.Length - head);
                //기존 배열의 헤드에서 새로운 배열에 0부터 기존배열에서 헤드길이 뺀 만큼 
                Array.Copy(array, 0, newArray, array.Length - head, tail);
                //기존 배열의 0부터 테일길이만큼 새로운배열 배열에서 헤드 뺀 길이까지
            }

            array = newArray;
            tail = Count;
            head = 0;
        }

        private bool IsFull()
        {
            if (head > tail)
            {
                return head == tail + 1;    //한칸 비어있긴한데 사고 미연방지
            }
            else
            {
                return head == 0 && tail == array.Length - 1;
            }
            //헤드가 첫째 테일이 맨 뒤쪽
        }

        private bool IsEmpty()
        {
            return head == tail;
        }

        private void MoveNext(ref int index)
        {
            index = (index + 1) % array.Length;
        }
    }
}