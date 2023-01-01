using Cadmus.Core.Config;
using Cadmus.Seed;
using Cadmus.Seed.General.Parts;
using Cadmus.Seed.Philology.Parts;
using Fusi.Microsoft.Extensions.Configuration.InMemoryJson;
using SimpleInjector;
using System.Reflection;
using Cadmus.Epigraphy.Parts;
using Cadmus.Seed.Geo.Parts;

namespace CadmusEpigraphyApi.Services;

public sealed class EpigraphyPartSeederFactoryProvider : IPartSeederFactoryProvider
{
    /// <summary>
    /// Gets the part/fragment seeders factory.
    /// </summary>
    /// <param name="profile">The profile.</param>
    /// <returns>Factory.</returns>
    /// <exception cref="ArgumentNullException">profile</exception>
    public PartSeederFactory GetFactory(string profile)
    {
        if (profile == null) throw new ArgumentNullException(nameof(profile));

        // build the tags to types map for parts/fragments
        Assembly[] seedAssemblies = new[]
        {
            // Cadmus.Seed.General.Parts
            typeof(NotePartSeeder).Assembly,
            // Cadmus.Seed.Philology.Parts
            typeof(ApparatusLayerFragmentSeeder).Assembly,
            // Cadmus.Seed.Epigraphy.Parts
            typeof(EpiSupportPart).Assembly,
            // Cadmus.Seed.Geo.Parts
            typeof(AssertedLocationsPartSeeder).Assembly
        };
        TagAttributeToTypeMap map = new();
        map.Add(seedAssemblies);

        // build the container for seeders
        Container container = new();
        PartSeederFactory.ConfigureServices(
            container,
            new StandardPartTypeProvider(map),
            seedAssemblies);

        container.Verify();

        // load seed configuration
        IConfigurationBuilder builder = new ConfigurationBuilder()
            .AddInMemoryJson(profile);
        var configuration = builder.Build();

        return new PartSeederFactory(container, configuration);
    }
}
