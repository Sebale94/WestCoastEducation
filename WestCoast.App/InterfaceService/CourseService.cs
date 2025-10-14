using WestCoast.App.Interfaces;
using Domain.Models;
using Persistance;
using System.Text.Json;
using System.Text.Encodings.Web;
using Persistance.Storages;

namespace WestCoast.App.InterfaceService;

public class CourseService(string path): ICourse
{
    private readonly string _path = path;
    private readonly FileStorage _jsonStorage = new();
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public string FetchCourses()
    {
        FileStorage fileStorage = new();
        return fileStorage.Read(_path);
    }

    public Course GetCourse()
    {
        var json = _jsonStorage.Read(_path);
        var course = JsonSerializer.Deserialize<Course>(json, _options);
        return course ?? new Course();
    }

    public void SaveCourses(string courses)
    {
        var json = JsonSerializer.Serialize(courses, _options);
        _jsonStorage.WriteJson<Course>(_path, json);
    }
}
