---
name: Naming Best Practices
applyTo: **/*.{cs,csproj}
description: |
  Enforce best practices for naming variables, constants, functions, classes, properties, and methods in all C# code and project files.

  - Use descriptive, meaningful names for all identifiers.
  - Variables and parameters: camelCase.
  - Constants: PascalCase or ALL_CAPS (project convention).
  - Methods and properties: PascalCase.
  - Classes and interfaces: PascalCase; interfaces prefixed with 'I'.
  - Avoid abbreviations unless industry standard.
  - No single-letter names except for loop indices.
  - Names must be in English.
  - Avoid Hungarian notation and type prefixes.
  - Use plural names for collections.
  - Use async suffix for async methods.
  - Prefer clarity over brevity.
  - Follow .NET and project-specific conventions where applicable.

---

# Naming Best Practices

All generated code must follow these naming conventions for clarity, maintainability, and consistency across the codebase. Deviations should be justified by strong project-specific reasons.

## Examples

- Variable: `userName`, `itemCount`
- Constant: `DefaultTimeout`, `MAX_RETRIES`
- Method: `GetUserName()`, `CalculateTotalAsync()`
- Class: `UserService`, `ChannelGuideOutputFormatter`
- Interface: `IUserService`, `IBackgroundServiceRequest`

## Rationale

Consistent naming improves code readability, reduces onboarding time, and prevents subtle bugs. These rules are based on .NET best practices and common C# standards.

## Related Customizations
- Consider adding rules for file/folder naming, test naming, or documentation standards.
- Enforce naming via static analysis or code review checklists.
