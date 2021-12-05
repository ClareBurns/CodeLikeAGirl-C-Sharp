using System.Collections.Generic;

namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Library
    {
        public List<Novel> Novels { get; set; }

        public List<TextBook> TextBooks { get; set; }

        public List<Album> Albums { get; set; }

        public List<AudioBook> AudioBooks { get; set; }

        public Library()
        {
            Novels = new List<Novel> { };
            TextBooks = new List<TextBook> { };
            Albums = new List<Album> { };
            AudioBooks = new List<AudioBook> { };
        }

        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }

        public void AddTextBook(TextBook textbook)
        {
            TextBooks.Add(textbook);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void AddAudioBook(AudioBook audiobook)
        {
            AudioBooks.Add(audiobook);
        }

    }
}