using OrchardCore.ResourceManagement;

namespace ThisNetWorksAdminTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("admin")
                .SetUrl("~/ThisNetWorksAdminTheme/Styles/theme.min.css", "~/ThisNetWorksAdminTheme/Styles/theme.css")
                .SetDependencies("jQuery-ui")
                .SetVersion("0.0.1");

        }
    }
}
