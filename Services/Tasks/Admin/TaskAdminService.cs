using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using TaskManager.Data;
using TaskManager.DTOs.Task.Admin;
using TaskManager.DTOs.Tasks.Admin;
using TaskManager.Interfaces.Tasks.Admin;

namespace TaskManager.Services.Tasks.Admin
{
    public class TaskAdminService(AppDbContext db):ITaskAdmin
    {
        public async Task CreateAsync(TaskCreationDto form)
        {
            var task = new Entities.Task
            {
                AssignedTo = form.AssignedTo,
                Description = form.Description,
                ExpiresAt = form.ExpiresAt,

            };

             db.Add(task);
            await db.SaveChangesAsync();

        }

        public async Task UpdateAsync(TaskUpdateDto form)
        {

            var task=await db.Tasks.FirstAsync(t=>t.Id==form.Id);
            task.AssignedTo=form.AssignedTo;
            task.Description=form.Description;
            task.ExpiresAt = form.ExpiresAt;

            await db.SaveChangesAsync();

        }

        public async Task DeleteAsync(int TaskId)
        {
            var task = await db.Tasks.FirstAsync(t => t.Id == TaskId);

            db.Remove(task);

            await db.SaveChangesAsync();
        }
    }
}
