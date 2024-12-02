namespace Bmb.Domain.Core.Events.Integration;

/// <summary>
/// New Product created event
/// </summary>
/// <param name="Id">Product ID</param>
/// <param name="Name">Product Name</param>
/// <param name="Category">Product Category</param>
public record ProductCreated(Guid Id, string Name, string Category) : IBmbIntegrationEvent;