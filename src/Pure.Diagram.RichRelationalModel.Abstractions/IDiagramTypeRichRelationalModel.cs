using Pure.Diagram.Model.Abstractions;
using Pure.Diagram.RelationalModel.Abstractions;

namespace Pure.Diagram.RichRelationalModel.Abstractions;

public interface IDiagramTypeRichRelationalModel
    : IDiagramType,
        IDiagramTypeRelationalModel;
