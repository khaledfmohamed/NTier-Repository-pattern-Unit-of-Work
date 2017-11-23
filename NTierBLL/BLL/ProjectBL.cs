using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierRepository.Repositories.Interfaces;
using NTierBLL.IBLL;
using NTierRepository.Repositories;
using MessageTube;
using Unity;
using NTierModel;

namespace NTierBLL.BLL
{
    public class ProjectBL : IProjectBL
    {
        IUnitOfWork _unitOfWork;
        IMessageList _messages;
        public ProjectBL(IUnitOfWork unitOfWork , IMessageList message)
        {
            _unitOfWork = unitOfWork;
            _messages = message;
        }
        public ProjectBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _messages = UnityConfig.Container.Resolve<IMessageList>();
        }
        public void AddNew(Project project )
        {
           
            _unitOfWork.Project.Add(project);
             
           
            _unitOfWork.Complete();
            

        }

        public Project Delete(int id )

        {
            Project project = null;
           
            try
            {
                 project = _unitOfWork.Project.Get(id);
                if (project != null)
                {
                    _unitOfWork.Project.Remove(_unitOfWork.Project.Get(id));
                    _unitOfWork.Complete();
                    
                }
                else
                    _messages.Add(new Message() { Body = Resource.RecordNotExist }  );
                return project;
            }
            catch (RepositoryException ex)
            {
                if(ex.ErrorCode == "SR-2")
                     _messages.Add(new Message() { Body = Resource.ESR2 }) ;
                else
                    _messages.Add(new Message() { Body = ex.Message } );
                return project;
            }
            
        }

        public void Edit(Project entity)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll(params String[] RelatedFields)
        {
          return  _unitOfWork.Project.GetAllWithInclude(RelatedFields);
        }

        public List<Project> Search(string cretria)
        {
            throw new NotImplementedException();
        }

        public void SetTimeBox(Project project, int timeBox)
        {
            project.IterationTimeBox = timeBox;
            _unitOfWork.Project.Update(project);
            _unitOfWork.Complete();


        }
    }
}
