﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Applications.Notes.Queries.GetNoteList
{
    public class GetNoteListQuery
        : IRequest<NoteListVm>
    {
        public Guid UserId { get; set; }

    }
}
