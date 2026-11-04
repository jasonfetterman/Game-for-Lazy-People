# THE GAME FOR LAZY PEOPLE
# TECHNICAL ARCHITECTURE
## Version 1.0 — Production Engineering Specification

---

# 1. DOCUMENT PURPOSE

This document defines the technical architecture for The Game for Lazy People.

It establishes:
- System boundaries.
- Code organization.
- Runtime responsibilities.
- Data ownership.
- Communication patterns.
- Persistence requirements.
- Automation architecture.
- AI behavior.
- Economy architecture.
- Performance requirements.
- Testing standards.
- Build and release requirements.

This document is the engineering authority for implementation.

The architecture must support a complete commercial game, not merely a prototype that works under ideal conditions.

All systems must be designed for integration, maintainability, testability, and controlled expansion.

# 2. TECHNOLOGY BASELINE

## 2.1 Engine and Language

| Technology | Standard |
|---|---|
| Game engine | Unity 6.2 |
| Rendering | Universal Render Pipeline |
| Programming language | C# |
| Input | Unity Input System |
| UI | Unity UI and TextMeshPro |
| Navigation | Unity AI Navigation |
| Configuration data | ScriptableObjects |
| Automated testing | Unity Test Framework |
| Version control | Git |
| Target platform | Windows PC initially |
| Distribution target | Steam |

The project must use Unity-supported APIs and package versions.

Do not assume that the installed system-wide .NET SDK determines the runtime supported by Unity.

## 2.2 Project Configuration

The project must maintain:
- Consistent asset naming.
- Consistent scene naming.
- Consistent C# namespaces.
- Stable serialized identifiers.
- Version-controlled project settings.
- Reproducible builds.
- Explicit package dependencies.

Package changes must be intentional and verified.

Do not add third-party packages without a demonstrated requirement.

# 3. ARCHITECTURAL PRINCIPLES

## 3.1 Single Responsibility

Every class must have a clearly defined responsibility.

Examples:
- A wallet manages currency balances.
- A shop processes purchase requests.
- An inventory manages owned portable items.
- A property system manages owned properties.
- An automation controller manages device execution.
- A save service serializes persistent game state.

A class must not become a general-purpose manager for unrelated functionality.

## 3.2 Explicit Ownership

Every piece of runtime state must have one authoritative owner.

For example:
- Credits belong to the economy.
- Owned inventory belongs to inventory management.
- Installed furniture belongs to property management.
- Device operating state belongs to its automation device.
- Character needs belong to the character condition system.

Other systems request changes through defined interfaces.

They must not independently modify another system's authoritative state.

## 3.3 Data and Behavior Separation

Reusable content definitions must be separated from runtime state.

ScriptableObjects define authored content.

Runtime objects hold changing gameplay state.

Example:

A dishwasher definition contains:
- Stable item ID.
- Display name.
- Purchase price.
- Capacity.
- Energy consumption.
- Cycle duration.
- Maintenance requirements.
- Upgrade options.

An installed dishwasher instance contains:
- Unique instance ID.
- Installation location.
- Current condition.
- Current cycle.
- Loaded contents.
- Operating state.
- Maintenance state.

Changing a runtime dishwasher must never modify the shared ScriptableObject definition.

## 3.4 Dependency Direction

Core gameplay systems must not depend on presentation systems.

The economy must not require a shopping screen to function.

Automation must not require an animation to determine whether a task succeeded.

The UI displays and requests changes from gameplay systems. It does not become the authority for game rules.

## 3.5 Fail Safely

Invalid operations must produce defined results.

Examples:
- An insufficient balance rejects a purchase.
- An occupied placement location rejects installation.
- A missing save field receives a safe default where appropriate.
- An unavailable navigation route produces a recoverable automation state.
- An invalid item ID is rejected with diagnostic information.

No important failure should silently corrupt game state.

# 4. ASSEMBLY AND NAMESPACE ORGANIZATION

Use the following namespace structure:

| Namespace | Responsibility |
|---|---|
| LazyPeople.Core | Application lifecycle and shared infrastructure |
| LazyPeople.Core.Events | Event contracts and dispatch |
| LazyPeople.Core.Time | Simulation clock and scheduling |
| LazyPeople.Core.Validation | Validation and result types |
| LazyPeople.Player | Character control and character state |
| LazyPeople.Interaction | World interaction |
| LazyPeople.Items | Item definitions and runtime instances |
| LazyPeople.Inventory | Ownership and storage |
| LazyPeople.Economy | Currency and financial transactions |
| LazyPeople.Shopping | Catalogs, checkout, and purchasing |
| LazyPeople.Property | Property ownership and management |
| LazyPeople.Placement | Object placement and validation |
| LazyPeople.Automation | Automation devices and task execution |
| LazyPeople.AI | Decision-making and autonomous behavior |
| LazyPeople.Needs | Character needs and condition |
| LazyPeople.Events | Gameplay events and incidents |
| LazyPeople.Progression | Unlocks and milestones |
| LazyPeople.Business | Business ownership and operations |
| LazyPeople.Persistence | Save data and loading |
| LazyPeople.UI | Presentation and user interface |
| LazyPeople.Audio | Music and sound management |

Editor-only tools must remain in Editor assemblies or Editor folders.

Runtime assemblies must never reference UnityEditor.

# 5. RUNTIME APPLICATION LIFECYCLE

The game must initialize its services in a predictable order.

## 5.1 Application Startup

Startup sequence:

1. Load application configuration.
2. Initialize diagnostic logging.
3. Initialize service infrastructure.
4. Initialize the persistent save service.
5. Load the selected profile or present profile selection.
6. Validate save data.
7. Initialize persistent gameplay state.
8. Load the appropriate scene.
9. Initialize scene-specific systems.
10. Enable player control.
11. Start simulation.

A system must not assume that another service is initialized merely because its GameObject exists.

Initialization dependencies must be explicit.

## 5.2 Scene Responsibilities

Initial scene organization:

| Scene | Responsibility |
|---|---|
| SCN_BOOT | Application startup and service initialization |
| SCN_MAIN_MENU | Profile selection and primary navigation |
| SCN_STARTER_APARTMENT | Initial playable property |
| SCN_PENTHOUSE | Luxury property |
| SCN_MANSION | High-end property |
| SCN_NEIGHBORHOOD | External world and services |
| SCN_COMMERCIAL_DISTRICT | Business and commercial activities |

Scene names are logical identifiers. The actual scene assets must be registered in build configuration before use.

## 5.3 Persistent Services

Only services that genuinely require cross-scene lifetime should persist.

Examples:
- Application state.
- Save service.
- Audio service.
- Session-level profile data.
- Simulation clock when appropriate.

Do not mark every manager as persistent.

Persistent services must have explicit initialization and shutdown behavior.

Duplicate service instances must be detected and rejected.

# 6. CORE SERVICE RESPONSIBILITIES

## 6.1 Game State Service

Owns the high-level application state.

States:
- Initializing.
- Main Menu.
- Loading Profile.
- Loading Property.
- Playing.
- Paused.
- Saving.
- Loading.
- Exiting.

Transitions must be validated.

A scene transition must not leave the game in a state where player input or simulation is accidentally active.

## 6.2 Simulation Clock

Owns gameplay time.

Responsibilities:
- Track simulation time.
- Support configurable time progression.
- Provide scheduled simulation updates.
- Support pause behavior.
- Notify interested systems of time changes.
- Avoid unnecessary per-frame processing.

Gameplay time must be distinguishable from real-world time.

## 6.3 Service Access

Dependencies should be supplied through initialization or explicit composition.

Avoid uncontrolled global access and arbitrary scene searches.

Use a composition root to create and connect major services.

A service should be replaceable in tests without requiring the entire game to run.

# 7. EVENT AND COMMUNICATION ARCHITECTURE

Systems communicate through explicit contracts.

Events communicate that something has happened.

Commands request that something happen.

Queries request information without changing authoritative state.

These concepts must not be confused.

## 7.1 Command Examples

- PurchaseItemCommand.
- InstallItemCommand.
- StartAutomationCommand.
- RepairDeviceCommand.
- UpgradeDeviceCommand.
- TransferInventoryCommand.

Commands must be validated by the system that owns the requested operation.

## 7.2 Event Examples

- CreditsChanged.
- PurchaseCompleted.
- PurchaseRejected.
- ItemInstalled.
- ItemRemoved.
- AutomationStarted.
- AutomationCompleted.
- AutomationFailed.
- DeviceMaintenanceRequired.
- PropertyUnlocked.
- BusinessIncomeReceived.

Events should contain the identifiers and values required by subscribers.

## 7.3 Event Rules

Events must:
- Have a clear meaning.
- Be published after the owning system commits the change.
- Avoid exposing mutable internal collections.
- Avoid creating circular dependencies.
- Have predictable subscription lifetimes.
- Be unsubscribed when their listeners are destroyed or disabled.

Do not use events as a substitute for every direct method call.

Use direct interfaces when a caller needs an immediate result.

Use events when independent systems need notification.

## 7.4 Transaction Boundaries

Important operations must be atomic from the player's perspective.

Example purchase:

1. Validate item availability.
2. Validate player funds.
3. Validate ownership restrictions.
4. Validate purchase requirements.
5. Calculate final cost.
6. Debit the wallet.
7. Create the ownership record.
8. Commit the transaction.
9. Publish PurchaseCompleted.

If the transaction fails, the player must not lose Credits without receiving the purchased item.

A transaction must have a defined rollback or recovery strategy for failures between steps.

# 8. PLAYER AND CHARACTER ARCHITECTURE

## 8.1 Player Controller

Responsibilities:
- Read input.
- Move the character.
- Rotate the character.
- Handle camera-relative movement.
- Handle jumping where supported.
- Request interactions.
- Handle movement restrictions.

The controller must not directly manage money, inventory ownership, or appliance logic.

## 8.2 Character State

Character runtime state includes:
- Stable character ID.
- Customization.
- Position and orientation.
- Current activity.
- Needs.
- Condition.
- Relevant progression state.

## 8.3 Character Activity

Activities must be represented explicitly.

Examples:
- Idle.
- Walking.
- Running.
- Interacting.
- Eating.
- Sleeping.
- Cleaning.
- Cooking.
- Working.
- Using Entertainment.

Activities must prevent conflicting actions.

For example, the player should not start a second exclusive interaction while an incompatible activity is running.

## 8.4 Needs System

Each need must have:
- Current value.
- Minimum and maximum.
- Change rate.
- Thresholds.
- Recovery sources.
- Gameplay effects.
- Persistence rules.

Need calculations must use simulation time rather than arbitrary frame-dependent increments.

The system must prevent values from exceeding their valid ranges.

# 9. INTERACTION ARCHITECTURE

## 9.1 Interaction Contracts

Interactive world objects expose a consistent interaction contract.

An interaction must communicate:
- Whether it is currently available.
- Available actions.
- Required conditions.
- Expected duration.
- Result.
- Failure reason.

## 9.2 Interaction Flow

1. Player input requests interaction.
2. Interaction detector identifies a target.
3. Target exposes available actions.
4. UI presents valid choices.
5. Player selects an action.
6. Owning system validates the request.
7. Action executes.
8. Result is reported.
9. Presentation updates.

The UI must never assume that an action succeeded before the gameplay system confirms it.

## 9.3 Interaction Safety

Interactions must handle:
- Target destruction.
- Target movement.
- Player movement out of range.
- Scene transitions.
- Interrupted activities.
- Invalid target state.

# 10. ITEM AND INVENTORY ARCHITECTURE

## 10.1 Item Definitions

Every purchasable or collectible item requires a stable ID.

Example IDs:
- furniture.sofa.basic
- appliance.refrigerator.basic
- appliance.dishwasher.standard
- automation.robot_vacuum.basic
- automation.robot_vacuum.advanced

IDs must remain stable across localization and display-name changes.

## 10.2 Item Definition Data

Item definitions may contain:
- Item ID.
- Display name.
- Description.
- Category.
- Icon.
- Prefab reference.
- Purchase price.
- Sale value.
- Weight.
- Dimensions.
- Placement rules.
- Installation requirements.
- Unlock requirements.
- Operating requirements.

## 10.3 Inventory Ownership

Inventory owns records of portable items.

An item ownership record must distinguish:
- Item definition ID.
- Unique instance ID.
- Quantity where stacking is allowed.
- Runtime condition.
- Relevant custom state.

Installed property objects must be represented by property installation records, not duplicated as portable inventory entries.

## 10.4 Unique Instance IDs

Every individually tracked object must have a unique persistent instance ID.

Two identical robot vacuums may share the same definition but must have different instance IDs.

This allows independent upgrades, damage, location, maintenance, and ownership.

# 11. ECONOMY ARCHITECTURE

## 11.1 Wallet

The wallet owns the player's available Credits.

Responsibilities:
- Read balance.
- Credit money.
- Debit money.
- Validate transactions.
- Report balance changes.
- Prevent negative balances unless a specifically designed credit system permits them.

All money values must use a consistent numeric representation.

Use integer minor units for currency calculations where practical to avoid floating-point rounding errors.

## 11.2 Financial Ledger

Every significant financial transaction must have a ledger record.

A record includes:
- Transaction ID.
- Transaction category.
- Amount.
- Simulation timestamp.
- Related item, business, or service ID.
- Description.
- Resulting balance.

The ledger supports debugging, transaction recovery, and future financial history screens.

## 11.3 Income and Expenses

Income and expenses must have explicit sources.

Examples:
- Employment income.
- Business income.
- Investment income.
- Item purchase.
- Utility expense.
- Maintenance expense.
- Service subscription.

Recurring costs must be scheduled through simulation time.

They must not be charged every rendered frame.

## 11.4 Economy Validation

Automated tests must verify:
- Exact purchase costs.
- Insufficient funds.
- Repeated purchase attempts.
- Refund behavior.
- Transaction rollback.
- Recurring expense timing.
- Balance persistence.
- Ledger consistency.

# 12. SHOPPING AND PURCHASE ARCHITECTURE

The shopping system reads available item definitions and progression restrictions.

It does not own the player's wallet or inventory.

Purchase flow:

1. Player requests purchase.
2. Catalog validates item availability.
3. Progression validates unlock requirements.
4. Economy validates affordability.
5. Purchase transaction executes.
6. Inventory or ownership system records the item.
7. Purchase result is returned.
8. UI updates.

The system must prevent:
- Purchasing locked items.
- Purchasing unavailable items.
- Duplicate unique purchases where prohibited.
- Negative purchase prices.
- Double charging from repeated input.
- Ownership records without corresponding transactions.

Purchase requests should have a unique request identifier to protect against accidental duplicate processing.

# 13. PROPERTY AND PLACEMENT ARCHITECTURE

## 13.1 Property Ownership

Property management owns:
- Property ID.
- Property tier.
- Ownership state.
- Room definitions.
- Available installation areas.
- Installed objects.
- Property upgrades.
- Property-specific configuration.

## 13.2 Placement Validation

Placement must validate:
- Property ownership.
- Valid placement surface.
- Position.
- Rotation.
- Object dimensions.
- Collision.
- Access clearance.
- Room restrictions.
- Required connections.
- Navigation impact where relevant.

Placement validation must be authoritative.

A preview object must not become a permanent installation until validation succeeds.

## 13.3 Installation Transaction

1. Identify owned item.
2. Validate property.
3. Validate placement.
4. Validate installation requirements.
5. Commit installation.
6. Create persistent installation record.
7. Update navigation or supporting systems if necessary.
8. Publish installation event.

If installation fails, ownership must remain intact.

# 14. AUTOMATION ARCHITECTURE

Automation is a core technical system and must be designed independently from individual robot prefabs.

## 14.1 Automation Device Contract

Every automation device must expose:
- Unique instance ID.
- Device definition.
- Operational state.
- Condition.
- Energy state.
- Current task.
- Capabilities.
- Upgrade state.
- Maintenance requirements.
- Diagnostic information.

## 14.2 Operational States

Standard states:
- Uninstalled.
- Installed.
- Inactive.
- Idle.
- Searching.
- Moving.
- PerformingTask.
- Returning.
- Charging.
- MaintenanceRequired.
- Blocked.
- Faulted.
- Disabled.

Transitions must be validated.

For example, a device cannot perform a task while uninstalled or faulted.

## 14.3 Task Architecture

Automation tasks must be separate from devices.

A task definition includes:
- Task ID.
- Target.
- Required capability.
- Priority.
- Estimated duration.
- Resource requirements.
- Preconditions.
- Completion conditions.
- Failure conditions.

The device evaluates available tasks and chooses a valid task according to its policy.

## 14.4 Task Lifecycle

1. Task becomes available.
2. Device discovers the task.
3. Device checks capability.
4. Device checks resource availability.
5. Device evaluates priority.
6. Device selects the task.
7. Device plans execution.
8. Device navigates or performs required movement.
9. Device performs the task.
10. Device verifies the result.
11. Device reports completion or failure.
12. Device selects another task or enters an idle state.

## 14.5 Task Priorities

Tasks may be ranked by:
- Player-assigned priority.
- Urgency.
- Distance.
- Resource cost.
- Expected benefit.
- Device capability.
- Existing task commitments.

Priority rules must be deterministic enough to debug.

Equal-priority tasks should use a stable tie-breaking rule.

## 14.6 Navigation

Mobile automation devices use navigation appropriate to their physical type.

Navigation must account for:
- Obstacles.
- Restricted areas.
- Doorways.
- Reachability.
- Dynamic furniture.
- Moving characters.
- Invalid destinations.

If a destination cannot be reached, the device must report a blocked or unreachable condition rather than pretending to complete the task.

## 14.7 Device Resources

Devices may consume:
- Battery.
- Electricity.
- Cleaning supplies.
- Replacement parts.
- Other task-specific resources.

Resource consumption must be calculated by the owning system.

A device must not continue an operation when essential resources are unavailable.

## 14.8 Device Condition and Maintenance

Condition changes must be based on defined usage and fault rules.

Maintenance may require:
- Time.
- Credits.
- Replacement components.
- Player interaction.
- External service.

Maintenance completion must restore the appropriate condition and clear only the faults it actually resolves.

## 14.9 Device Upgrades

Upgrades must be data-driven.

Examples:
- Larger battery.
- Better navigation.
- Increased storage.
- Faster task execution.
- Improved cleaning efficiency.
- Reduced energy use.
- Better fault detection.

Upgrade effects must be applied through defined modifiers, not scattered hardcoded checks.

# 15. AI AND DECISION-MAKING

## 15.1 AI Responsibility

AI chooses actions based on available information and defined policies.

AI does not own:
- Currency.
- Item ownership.
- Property ownership.
- Persistent transaction records.

AI requests actions from the relevant gameplay system.

## 15.2 Decision Inputs

Decision-making may use:
- Current device state.
- Available tasks.
- Capabilities.
- Navigation results.
- Energy.
- Condition.
- Player priorities.
- World conditions.
- Current commitments.

## 15.3 Decision Strategy

Initial automation can use deterministic utility scoring.

A candidate task receives a score based on urgency, priority, distance, resource cost, and expected benefit.

Invalid tasks are excluded before scoring.

The selected task must always pass a final validation check.

This approach is preferred initially because it is easier to test and debug than an unnecessarily complex general AI framework.

## 15.4 Decision Frequency

AI decisions must not run without limits every frame.

Use scheduled decision intervals and immediate reevaluation for important events.

Examples:
- Current task completed.
- Current task failed.
- Device became blocked.
- Battery reached a critical threshold.
- New high-priority task appeared.

## 15.5 Diagnostics

AI decisions should be inspectable during development.

Diagnostics should show:
- Available candidates.
- Rejected candidates and reasons.
- Candidate scores.
- Selected action.
- Current task.
- State transition.
- Failure reason.

Diagnostic logging must be configurable and must not flood production logs.

# 16. EVENTS AND INCIDENTS

The event system owns gameplay incidents.

Each event definition contains:
- Stable event ID.
- Trigger conditions.
- Frequency rules.
- Eligibility rules.
- Available choices.
- Outcomes.
- Rewards.
- Penalties.
- Cooldown.
- Presentation references.

Events must not directly manipulate unrelated systems.

An event outcome requests validated changes from the appropriate system.

For example, an appliance failure event requests a condition change from the appliance system and may request a repair expense from the economy.

# 17. BUSINESS ARCHITECTURE

Business management is separate from household economy presentation.

A business instance owns:
- Unique instance ID.
- Business definition ID.
- Ownership.
- Operating state.
- Employees or automation assignments.
- Revenue.
- Expenses.
- Upgrade levels.
- Condition.
- Performance metrics.

Business simulation must use bounded updates.

A business must not require continuous per-frame processing when its state can be calculated from elapsed simulation time.

Income generation must be validated and recorded through the economy.

# 18. PROGRESSION ARCHITECTURE

Progression owns:
- Unlock definitions.
- Completion records.
- Milestones.
- Eligibility requirements.
- Reward grants.

Unlock conditions must be data-driven.

Progression must not directly manipulate UI elements.

When a milestone is completed:
1. Validate requirements.
2. Record completion.
3. Grant authorized rewards.
4. Publish progression event.
5. Allow UI to display the result.

Rewards must not be granted twice because of repeated event delivery or save loading.

# 19. SAVE AND PERSISTENCE ARCHITECTURE

Persistence is one of the highest-risk systems and must be implemented carefully.

## 19.1 Data Separation

Persistent data must be separated from live Unity object references.

Do not serialize scene GameObjects, arbitrary MonoBehaviour references, or runtime object pointers as the primary save representation.

Use serializable data transfer structures.

## 19.2 Save Structure

The save model should contain:

- Schema version.
- Save slot ID.
- Profile identity.
- Creation timestamp.
- Last saved timestamp.
- Playtime.
- Wallet state.
- Financial ledger.
- Character state.
- Needs.
- Inventory ownership.
- Property ownership.
- Installed objects.
- Automation device state.
- Business state.
- Progression state.
- Relevant world state.

## 19.3 Stable Identifiers

All persistent entities must use stable IDs.

Never use:
- GameObject names.
- Scene hierarchy paths.
- Array positions.
- Display labels.

as the sole identity of persistent gameplay objects.

## 19.4 Save Process

1. Request save.
2. Confirm game state permits saving.
3. Gather authoritative state.
4. Validate the snapshot.
5. Serialize to a temporary file.
6. Flush data to disk where supported.
7. Verify the temporary file.
8. Replace the target save safely.
9. Retain a recoverable backup.
10. Report success or failure.

A failed write must not destroy the last valid save.

## 19.5 Load Process

1. Locate selected slot.
2. Validate file existence.
3. Parse save data.
4. Validate schema.
5. Run required migrations.
6. Validate identifiers and values.
7. Construct runtime state.
8. Resolve content definitions.
9. Restore scene-specific objects.
10. Verify critical systems.
11. Enable gameplay.

If a save is invalid, preserve the original file and report the problem.

## 19.6 Schema Migration

Save data must have a schema version.

When the structure changes:
- Provide an explicit migration path.
- Preserve compatible information.
- Supply safe defaults for new fields.
- Reject unsupported future versions without overwriting them.

## 19.7 Save Testing

Tests must cover:
- New game.
- Normal save.
- Normal load.
- Multiple slots.
- Missing file.
- Corrupt file.
- Interrupted write.
- Backup recovery.
- Unknown item definition.
- Missing property definition.
- Old schema migration.
- Future schema rejection.

# 20. USER INTERFACE ARCHITECTURE

The UI is a presentation layer.

It must request operations from gameplay systems and display confirmed results.

## 20.1 UI Responsibilities

- Present information.
- Collect player input.
- Display available actions.
- Display validation errors.
- Display transaction results.
- Present progression.
- Support accessibility.
- Manage navigation between screens.

## 20.2 UI Restrictions

UI components must not:
- Directly change Credits.
- Create ownership records.
- Install objects without validation.
- Change automation state without an approved request.
- Write save files independently.
- Become the authoritative source of gameplay state.

## 20.3 UI State

UI state may include:
- Open panel.
- Selected item.
- Current filter.
- Scroll position.
- Active tab.
- Pending confirmation.

Temporary UI state must not accidentally become persistent gameplay state.

## 20.4 Feedback

Every important request must provide:
- Pending feedback when necessary.
- Success feedback.
- Failure feedback.
- Clear reason for rejection.

# 21. AUDIO ARCHITECTURE

Audio services own:
- Music playback.
- Ambient sound.
- One-shot sound effects.
- UI sound effects.
- Audio settings.
- Mixer configuration.

Gameplay systems publish or request audio events.

Gameplay rules must not depend on audio playback succeeding.

Audio assets must be configurable and referenced through controlled definitions.

# 22. PERFORMANCE ARCHITECTURE

## 22.1 Simulation Scheduling

Not every system needs a per-frame update.

Use:
- Frame updates for movement and immediate visual response.
- Fixed updates for physics.
- Scheduled updates for needs and economy.
- Task-based updates for automation.
- Event-driven updates for state changes.

## 22.2 Object Lifecycle

Frequently created objects should use pooling where profiling demonstrates a benefit.

Pooled objects must have explicit reset behavior.

A reused object must not retain state from its previous use.

## 22.3 Automation Scaling

The system must support multiple active devices.

AI evaluation, navigation, and task discovery must be bounded.

Distant or inactive systems may use reduced simulation frequency where gameplay correctness permits it.

## 22.4 Performance Measurement

Measure:
- Main thread time.
- Rendering time.
- Memory usage.
- Garbage collection.
- Navigation cost.
- Physics cost.
- Active automation count.
- Scene loading time.
- Save duration.

Optimization must be based on profiling, not guesswork.

# 23. ERROR HANDLING AND DIAGNOSTICS

Critical systems must return explicit results.

An operation result should communicate:
- Success or failure.
- Result category.
- Relevant entity ID.
- Diagnostic reason.
- Whether retry is appropriate.

Expected gameplay failures should not be treated as application crashes.

Unexpected exceptions must be logged with sufficient context.

Logs must distinguish:
- Informational messages.
- Warnings.
- Recoverable errors.
- Critical failures.

Do not suppress exceptions without a recovery strategy.

# 24. SECURITY AND DATA INTEGRITY

The initial game is single-player, but its architecture should avoid fragile assumptions about local data.

Requirements:
- Validate all loaded values.
- Reject invalid transaction amounts.
- Validate stable identifiers.
- Prevent duplicate reward grants.
- Protect save replacement.
- Avoid arbitrary executable data in saves.
- Keep developer diagnostics separate from player-facing UI.

If online features are introduced later, client-side state must not be treated as authoritative for competitive or shared transactions.

# 25. TESTING ARCHITECTURE

## 25.1 Edit Mode Tests

Edit Mode tests validate logic without requiring a full gameplay scene.

Required areas:
- Economy calculations.
- Purchase validation.
- Item definitions.
- Inventory operations.
- Placement rules.
- Progression requirements.
- Automation scoring.
- Save serialization.
- Save migration.
- Event eligibility.

## 25.2 Play Mode Tests

Play Mode tests validate integrated runtime behavior.

Required areas:
- Player movement.
- Interaction range.
- Appliance operation.
- Installation.
- Navigation.
- Automation execution.
- Device failures.
- Scene transitions.
- Save and restore.
- UI integration.

## 25.3 Acceptance Tests

A complete gameplay feature must be verified through a player-facing scenario.

Example: Robot Vacuum Purchase

1. Player has sufficient Credits.
2. Player opens the catalog.
3. Player selects the robot vacuum.
4. Purchase succeeds.
5. Credits decrease by the exact amount.
6. Ownership is recorded.
7. Player places the device.
8. Placement is validated.
9. Device becomes operational.
10. Device identifies a cleaning task.
11. Device navigates to the target.
12. Device performs cleaning.
13. Cleaning result is verified.
14. Device reports completion.
15. Player saves.
16. Player reloads.
17. Device ownership, location, condition, and configuration are restored.

A feature is not complete until its normal path and important failure paths are tested.

# 26. BUILD AND RELEASE ARCHITECTURE

## 26.1 Build Configuration

Build settings must be version controlled.

The initial target is Windows 64-bit.

Build output must be separate from source assets.

## 26.2 Build Verification

A release build must pass:
- Compilation.
- Scene inclusion validation.
- Required asset validation.
- Startup test.
- Save/load test.
- Input test.
- Critical gameplay test.
- Performance smoke test.

## 26.3 Build Reproducibility

Record:
- Unity version.
- Package manifest.
- Build target.
- Build configuration.
- Build timestamp.
- Git commit.
- Build result.

A release build should be traceable to an exact source revision.

# 27. SOURCE CONTROL AND CHANGE MANAGEMENT

Git is the project's source-of-truth history.

Requirements:
- Commit completed, verified milestones.
- Keep generated Unity folders out of source control.
- Do not commit temporary build output.
- Do not commit personal editor settings unless intentionally required.
- Review changes before committing.
- Preserve known-good checkpoints.
- Avoid destructive resets without explicit inspection.

Scene and prefab modifications must be reviewed carefully.

Before automated scene modifications:
1. Confirm the target scene.
2. Create a recoverable backup.
3. Inspect the intended objects.
4. Apply the smallest necessary change.
5. Reopen and validate the scene.
6. Verify important references.
7. Commit only after successful verification.

# 28. IMPLEMENTATION ORDER

Implementation must follow dependency order.

## Phase 1: Core Foundation
- Application lifecycle.
- Game state.
- Logging.
- Service composition.
- Simulation clock.
- Basic scene transition.

## Phase 2: Player Foundation
- Input.
- Character movement.
- Camera.
- Interaction detection.
- Interaction contracts.

## Phase 3: World and Items
- Item definitions.
- Runtime item instances.
- Inventory.
- Property ownership.
- Placement validation.

## Phase 4: Economy
- Wallet.
- Financial ledger.
- Catalog.
- Purchase transactions.
- Operating expenses.

## Phase 5: Character Gameplay
- Needs.
- Activities.
- Manual household tasks.
- Character recovery.

## Phase 6: Automation
- Device contracts.
- Task definitions.
- Task selection.
- Navigation.
- Execution.
- Resource consumption.
- Maintenance.
- Failure recovery.

## Phase 7: Persistence
- Save model.
- Serialization.
- Save slots.
- Loading.
- Validation.
- Migration.
- Backup recovery.

## Phase 8: Progression and Content
- Unlocks.
- Events.
- Businesses.
- Upgrades.
- Additional properties.
- Content expansion.

## Phase 9: Presentation and Production
- Complete UI.
- Audio.
- Visual effects.
- Accessibility.
- Optimization.
- Build verification.

This order may be adjusted when a verified dependency requires it, but implementation must not skip foundational ownership and validation rules.

# 29. DEFINITION OF DONE

A production feature is complete only when:

1. Its purpose is documented.
2. Its owner is defined.
3. Its inputs and outputs are defined.
4. Its data model is complete.
5. Its runtime implementation is complete.
6. It is integrated with dependent systems.
7. It has appropriate player feedback.
8. Normal operation is tested.
9. Failure cases are tested.
10. Persistence is tested where applicable.
11. Performance is measured where relevant.
12. No critical placeholder behavior remains.
13. Unity Console is free of relevant errors.
14. Documentation is updated.
15. The verified result is committed to Git.

A compiling script alone does not satisfy this definition.

# 30. ARCHITECTURAL DECISIONS

The following decisions are authoritative unless deliberately revised:

| Decision | Standard |
|---|---|
| Game architecture | Modular, data-driven |
| Primary language | C# |
| Engine | Unity 6.2 |
| Render pipeline | URP |
| Content definitions | ScriptableObjects |
| Persistent runtime identity | Stable unique IDs |
| Currency | Integer minor units where practical |
| System communication | Commands, interfaces, and events |
| Automation | Independent devices and task execution |
| AI decisions | Deterministic utility scoring initially |
| Persistence | Versioned data snapshots |
| Save safety | Temporary write, validation, backup |
| UI role | Presentation and input |
| Testing | Edit Mode, Play Mode, acceptance |
| Source control | Git |
| First platform | Windows PC |
| Multiplayer | Not required for initial release |

# 31. FINAL ENGINEERING PRINCIPLE

The game must be built as one coherent simulation.

The player, property, appliances, economy, inventory, automation devices, businesses, and world events must interact through clearly defined systems.

A purchase must create real ownership.

An installation must create a real object in the property.

An automation device must perform real work.

A completed task must produce a real gameplay result.

A save must preserve the player's actual progress.

The interface must represent the real state of the simulation.

**The goal is not to make a collection of menus that looks like a game. The goal is to build a complete, reliable, entertaining simulation that players will want to own.**
