---
name: Code Documentation and Comment Preservation
applyTo: **/*
description: |

    The copilot agent must never remove inline comments from user code. When generating or updating code, copilot may update comments only if the code change invalidates the comment's content or context. All generated code blocks should include clear, relevant comments explaining logic, intent, or important details.

    - All public classes, methods, and properties must include XML documentation comments (C#) or docstrings (other languages) summarizing their purpose, parameters, and return values.
    - Comments should focus on explaining the intent and reasoning behind code decisions, not just describing what the code does.
    - All comments must be written in clear, professional English, avoiding slang or ambiguous language.

    - Never delete user inline comments, even during refactors or cleanups.
    - If a code change makes a comment inaccurate, update the comment to match the new code.
    - All generated code must be properly commented for clarity and maintainability.
    - Comments should be concise, in clear, professional English, and placed above or beside the relevant code.
    - Do not add redundant or obvious comments (e.g., "// increment i by 1" for `i++`).
    - Respect project or language-specific commenting conventions.

---

# Code Documentation and Comment Preservation

Copilot must always preserve user inline comments. When code changes invalidate a comment, update it to reflect the new logic. All generated code should be well-commented to aid understanding and future maintenance.

## Additional Requirements

- All public APIs (classes, methods, properties) must include XML documentation comments (C#) or docstrings (other languages) summarizing their purpose, parameters, and return values.
- Comments should explain the intent and reasoning behind code, not just describe what the code does.
- All comments must be written in clear, professional English.


## Examples

- When refactoring a method, retain all user comments unless they are no longer relevant; update them if the logic changes.
- When generating a new class or function, include summary comments and inline explanations for complex logic.

- When adding a public method, include an XML doc comment explaining its purpose, parameters, and return value.
- Add comments that clarify why a particular algorithm or workaround is used, not just what it does.


## Rationale

Preserving and updating comments ensures that important context and documentation are not lost during code generation or refactoring. Well-commented code improves maintainability and onboarding for new contributors.

Requiring documentation comments for public APIs ensures discoverability and usability. Focusing on intent in comments helps future maintainers understand design decisions. Professional English ensures clarity and inclusivity for all contributors.

## Related Customizations
- Enforce documentation comment standards (e.g., XML docs for C#).
- Require comments for all public methods and classes.
- Add rules for TODO/FIXME comment handling.
