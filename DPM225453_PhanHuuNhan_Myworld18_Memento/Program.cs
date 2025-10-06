using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld17_Memento
{
    /// <summary>
    /// Memento Design Pattern - Ví dụ: Text Editor Undo/Redo
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            History history = new History();

            // Viết nội dung đầu tiên
            editor.Content = "Xin chào!";
            history.Mementos.Push(editor.Save());

            // Viết thêm
            editor.Content = "Xin chào! Hôm nay trời đẹp.";
            history.Mementos.Push(editor.Save());

            // Viết thêm nữa
            editor.Content = "Xin chào! Hôm nay trời đẹp. Tôi đang học Design Pattern.";
            history.Mementos.Push(editor.Save());

            Console.WriteLine("\n--- Hiện tại ---");
            Console.WriteLine(editor.Content);

            // Thực hiện Undo (quay lại trạng thái trước)
            if (history.Mementos.Count > 0)
            {
                editor.Restore(history.Mementos.Pop());
            }

            Console.WriteLine("\n--- Sau khi Undo ---");
            Console.WriteLine(editor.Content);

            // Undo thêm 1 lần
            if (history.Mementos.Count > 0)
            {
                editor.Restore(history.Mementos.Pop());
            }

            Console.WriteLine("\n--- Sau khi Undo lần 2 ---");
            Console.WriteLine(editor.Content);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Originator - Trình soạn thảo
    /// </summary>
    public class TextEditor
    {
        public string Content { get; set; }

        public EditorMemento Save()
        {
            Console.WriteLine($"[Save] Lưu trạng thái: \"{Content}\"");
            return new EditorMemento(Content);
        }

        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
            Console.WriteLine($"[Restore] Phục hồi trạng thái: \"{Content}\"");
        }
    }

    /// <summary>
    /// Memento - Lưu trạng thái văn bản
    /// </summary>
    public class EditorMemento
    {
        public string Content { get; private set; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }

    /// <summary>
    /// Caretaker - Lịch sử soạn thảo
    /// </summary>
    public class History
    {
        public Stack<EditorMemento> Mementos { get; private set; } = new Stack<EditorMemento>();
    }
}
