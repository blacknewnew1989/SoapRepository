﻿using QADAL.EntityFrameWorkCore;
using QADAL.EntityFrameWorkCore.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAServer.Server
{
    public class TypeServer:BaseServer,IBaseServer<QADAL.EntityFrameWorkCore.Models.Type>
    {
         TypeRepoistory typerepoistory;
         public TypeServer() 
            : base(new QuestionContext()) 
        {
            typerepoistory = new TypeRepoistory(IUnitOfWork);        
        }
        public QADAL.EntityFrameWorkCore.Models.Type Add(QADAL.EntityFrameWorkCore.Models.Type entity)
        {
            return typerepoistory.Insert(entity);
        }

        public void Add(IEnumerable<QADAL.EntityFrameWorkCore.Models.Type> entity)
        {
            typerepoistory.Insert(entity);
        }

        public void Delete(params object[] id)
        {
            var temp =typerepoistory.Find(id);
            typerepoistory.Delete(temp);
        }

        public void Delete(System.Linq.Expressions.Expression<Func<QADAL.EntityFrameWorkCore.Models.Type, bool>> func)
        {
            typerepoistory.Delete(func);
        }

        public void Delete(IEnumerable<QADAL.EntityFrameWorkCore.Models.Type> entity)
        {
            typerepoistory.Delete(entity);
        }

        public void UpDate(QADAL.EntityFrameWorkCore.Models.Type entity)
        {
            typerepoistory.Update(entity);
        }

        public void UpDate(IEnumerable<QADAL.EntityFrameWorkCore.Models.Type> entity)
        {
            typerepoistory.Update(entity);
        }

        public QADAL.EntityFrameWorkCore.Models.Type FindModel(params object[] arr)
        {
            return typerepoistory.Find(arr);
        }

        public IEnumerable<QADAL.EntityFrameWorkCore.Models.Type> FindModelList()
        {
            return typerepoistory.GetModelList();
        }

        public IEnumerable<QADAL.EntityFrameWorkCore.Models.Type> FindModelList(System.Linq.Expressions.Expression<Func<QADAL.EntityFrameWorkCore.Models.Type, bool>> func)
        {
            return typerepoistory.GetModelList(func);
        }

       
    }
}
