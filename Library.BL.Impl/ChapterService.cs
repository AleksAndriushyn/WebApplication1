using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;

namespace Library.Bl.Impl
{
    public class ChapterService : ChapterRepository, IChapterService
    {
        public ChapterService(LibraryContext context) : base(context)
        {

        }
    }
}
