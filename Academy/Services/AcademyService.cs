using Academy.Data;
using Academy.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Academy.Services
{
    public class AcademyService
    {
        private readonly AppDbContext _context;

        public AcademyService(AppDbContext context)
        {
            _context = context;
        }

        // Методы для работы со студентами
        public async Task<List<Student>> GetStudentsAsync()
        {
            try
            {
                var result = await _context.Students.ToListAsync();
                return result ?? new List<Student>(); // Гарантируем, что не вернем null
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении студентов: {ex.Message}");
                return new List<Student>(); // Всегда возвращаем пустой список вместо null
            }
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        // Методы для работы с преподавателями
        public async Task<List<Teacher>> GetTeachersAsync()
        {
            return await _context.Teachers.ToListAsync();
        }

        // Методы для работы с группами
        public async Task<List<Group>> GetGroupsAsync()
        {
            return await _context.Groups.Include(g => g.DirectionNavigation).ToListAsync();
        }

        // Методы для работы с расписанием
        public async Task<List<Schedule>> GetScheduleAsync()
        {
            return await _context.Schedules
                .Include(s => s.GroupNavigation)
                .Include(s => s.DisciplineNavigation)
                .Include(s => s.TeacherNavigation)
                .ToListAsync();
        }

        // Методы для работы с посещаемостью
        public async Task<List<Attendance>> GetAttendanceAsync()
        {
            return await _context.Attendances
                .Include(a => a.StudentNavigation)
                .Include(a => a.LessonNavigation)
                .ToListAsync();
        }

        // Добавьте другие методы по необходимости для ваших таблиц
    }
}


