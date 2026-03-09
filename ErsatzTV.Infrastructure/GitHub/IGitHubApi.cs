using ErsatzTV.Infrastructure.GitHub.Models;
using Refit;

namespace ErsatzTV.Infrastructure.GitHub;

[Headers("Accept: application/vnd.github.v3+json", "User-Agent: rathinosk/ErsatzTV")]
public interface IGitHubApi
{
    [Get("/repos/rathinosk/ErsatzTV/releases")]
    Task<List<GitHubTag>> GetReleases(CancellationToken cancellationToken);

    [Get("/repos/rathinosk/ErsatzTV/releases/tags/{tag}")]
    Task<GitHubTag> GetTag(string tag, CancellationToken cancellationToken);
}
