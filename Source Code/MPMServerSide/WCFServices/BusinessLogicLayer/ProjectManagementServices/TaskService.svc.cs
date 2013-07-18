using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskService" in code, svc and config file together.
    public class TaskService : ITaskService
    {
        public int AddNewTask(Task task)
        {
            throw new NotImplementedException();
        }

        public int DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public int UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTaskbyUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void CheckTaskOverDue(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTaskbyProject(int projectid)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTaskbyState(int stateId)
        {
            throw new NotImplementedException();
        }

        public List<Task> UpdateTaskStatus(List<Task> list)
        {
            throw new NotImplementedException();
        }

        public void UpdateTimePlan(int taskId, DateTime startDate, DateTime dueDate)
        {
            throw new NotImplementedException();
        }
    }
}
