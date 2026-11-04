# THE GAME FOR LAZY PEOPLE
# PLAYER EXPERIENCE AND USER INTERFACE SPECIFICATION
## Version 1.0 — Production UX Specification

---

## 1. PURPOSE

This document defines how players experience, navigate, understand, and interact with The Game for Lazy People.

The game is a 3D simulation first. Menus and management interfaces support the world rather than replacing it.

The player must always understand:
- Where they are.
- What they can interact with.
- What needs attention.
- What actions are available.
- What an action will cost.
- What an action will accomplish.
- How their lifestyle and automation systems are progressing.

The interface must communicate convenience, humor, personality, and control without overwhelming the player.

## 2. EXPERIENCE PILLARS

### 2.1 World-first interaction

The apartment, neighborhood, businesses, and other environments must remain central to the experience.

The player should physically encounter:
- Appliances.
- Furniture.
- Robots.
- Delivery services.
- Maintenance workers.
- Interactive objects.
- Environmental events.
- Other characters.

Management interfaces should connect to these physical objects whenever practical.

### 2.2 Low-friction interaction

The game is about eliminating unnecessary effort.

Its controls must not introduce unnecessary effort of their own.

Important actions should be easy to discover, predictable, and consistent.

### 2.3 Information without clutter

The interface should show essential information at the moment it matters.

Detailed information should be available through inspection rather than permanently occupying the screen.

### 2.4 Meaningful feedback

Every important action must produce understandable feedback.

Examples:
- A purchase reduces the wallet balance.
- A robot visibly begins its assigned task.
- A completed task changes the environment.
- An appliance reports its operating condition.
- A business reports actual revenue.
- An upgrade changes measurable performance.

### 2.5 Comedy through presentation

Humor should appear through:
- Character animation.
- Robot behavior.
- Notification wording.
- Product descriptions.
- Unexpected situations.
- Achievement names.
- Environmental storytelling.
- Audio reactions.

Humor must not obscure important information.

## 3. TARGET PLATFORM AND INPUT

### 3.1 Initial platform

Primary release platform: Windows PC through Steam.

Initial interaction priorities:
1. Keyboard and mouse.
2. Controller.
3. Steam Deck-compatible interface behavior where practical.

Console-specific adaptations are outside the initial release requirement but should not require a complete interface redesign.

### 3.2 Input architecture

Use Unity's Input System.

Input actions must be centralized and configurable.

Required action groups:
- Player Movement.
- Camera.
- Interaction.
- Object Inspection.
- Inventory.
- Placement.
- Navigation.
- Menus.
- Management.
- Accessibility.

The UI must not hardcode physical keyboard keys into gameplay logic.

### 3.3 Default keyboard and mouse controls

| Action | Default input |
|---|---|
| Move | WASD |
| Camera | Mouse |
| Interact | E |
| Inspect | F |
| Cancel / Back | Escape |
| Inventory | I |
| Phone / Management | Tab |
| Jump | Space |
| Sprint | Left Shift |
| Crouch | Left Ctrl |
| Confirm | Enter |
| Quick access | Q |
| Pause | Escape |

These bindings are initial defaults and must be rebindable.

### 3.4 Controller controls

The controller layout must support:
- Movement.
- Camera control.
- Interaction.
- Inspection.
- Selection.
- Confirmation.
- Cancellation.
- Inventory.
- Management interface.
- Menu navigation.

All essential gameplay must be achievable without a mouse.

## 4. PLAYER EXPERIENCE FLOW

### 4.1 Launch flow

Expected flow:

1. Game startup.
2. Studio and publisher presentation where applicable.
3. Main menu.
4. New Game, Continue, Load Game, Settings, Credits, Exit.
5. New game configuration where applicable.
6. Opening sequence.
7. Starter apartment.
8. First playable objective.

The opening must reach meaningful player interaction quickly.

### 4.2 First-time experience

The opening tutorial introduces:

1. Movement.
2. Camera control.
3. Object interaction.
4. First household inconvenience.
5. Manual task completion.
6. Reward collection.
7. First purchase.
8. Product installation.
9. First convenience improvement.
10. Introduction to the broader progression loop.

Tutorial guidance must be contextual and dismissible.

Players must not be forced to repeat tutorials after completing them.

### 4.3 Returning player flow

Continue must restore:
- Player position.
- Current property.
- Owned objects.
- Object condition.
- Active automation.
- Business state.
- Economy.
- Current objectives.
- World state.
- Time and progression.

The player should be able to resume quickly without navigating unnecessary screens.

## 5. MAIN MENU

The main menu must be visually polished and communicate the game's identity.

Required options:
- Continue.
- New Game.
- Load Game.
- Settings.
- Credits.
- Exit.

Additional options may include:
- Accessibility.
- News.
- Community links.

The menu must support keyboard, mouse, and controller navigation.

Continue must be disabled or appropriately replaced when no valid save exists.

Load Game must display actual save metadata.

New Game must warn before replacing or deleting existing progress.

## 6. PLAYER CHARACTER

### 6.1 Character interaction

The player controls a third-person character.

Required capabilities:
- Walking.
- Running.
- Jumping where appropriate.
- Crouching where appropriate.
- Turning.
- Looking.
- Interacting.
- Carrying supported objects.
- Using equipment.
- Inspecting objects.
- Entering and exiting vehicles or transport where implemented.

### 6.2 Character presentation

The character must have:
- Idle animations.
- Movement animations.
- Interaction animations.
- Carrying animations.
- Contextual reactions.
- Clothing customization.
- Appearance customization.

Character appearance must persist through save/load.

### 6.3 Camera behavior

The camera must:
- Maintain comfortable viewing distance.
- Avoid unnecessary obstruction.
- Handle walls and furniture.
- Avoid abrupt clipping.
- Support adjustable sensitivity.
- Support invert options.
- Support field-of-view settings where appropriate.

Camera collision must be tested in small rooms and narrow spaces.

## 7. WORLD INTERACTION SYSTEM

### 7.1 Interaction discovery

Interactive objects must provide visible or contextual indicators.

Indicators may include:
- Highlighting.
- Small interaction icons.
- Context labels.
- Distance-based prompts.
- Audio cues.

Indicators must not illuminate every object simultaneously.

### 7.2 Interaction prompt

A typical prompt contains:
- Action.
- Input.
- Object name.

Example:

`[E] Interact — Refrigerator`

When multiple actions exist, the interaction interface must provide a clear selection.

### 7.3 Object inspection

Inspection displays relevant information:

- Name.
- Category.
- Condition.
- Operating state.
- Available actions.
- Ownership.
- Upgrade status.
- Maintenance requirements.
- Automation compatibility.

Inspection data must reflect the actual object instance.

### 7.4 Object action rules

An action must be unavailable when its prerequisites are not satisfied.

The UI must explain why.

Examples:
- Insufficient money.
- Missing required component.
- Object currently operating.
- Maintenance required.
- No available power.
- Player too far away.
- Required upgrade not installed.

## 8. PRIMARY IN-GAME HUD

The HUD must remain compact.

### 8.1 Core HUD elements

The default HUD includes:

- Current Credits.
- Current time.
- Current objective.
- Contextual interaction prompt.
- Notification indicator.
- Optional player status indicators.

### 8.2 HUD behavior

The HUD must:
- Respect safe display areas.
- Scale to supported resolutions.
- Avoid covering important world interactions.
- Support opacity and visibility settings.
- Allow contextual elements to disappear when irrelevant.
- Support controller focus and selection.

### 8.3 HUD information hierarchy

Most important:
1. Immediate interaction.
2. Current objective.
3. Financial information relevant to an active transaction.
4. Important warnings.

Secondary:
- Time.
- Optional status.
- Notification summaries.

Detailed economic information belongs in management interfaces.

## 9. PLAYER PHONE AND MANAGEMENT DEVICE

The phone or equivalent management device is the primary remote access interface.

It provides access to:

- Wallet.
- Shopping.
- Inventory.
- Tasks.
- Schedule.
- Property information.
- Automation.
- Robots.
- Businesses.
- Services.
- Financial overview.
- Notifications.
- Contracts.
- Map.
- Settings.

The phone must not replace physical interaction when physical interaction is the intended gameplay experience.

### 9.1 Phone behavior

The interface must:
- Open and close quickly.
- Preserve navigation state when appropriate.
- Display actual simulation data.
- Support controller navigation.
- Provide clear back navigation.
- Prevent accidental purchases.
- Display important notifications.

### 9.2 App organization

Apps must be grouped logically.

The player must not need to scroll through an enormous unstructured application list.

Frequently used functions should be easy to reach.

## 10. SHOPPING INTERFACE

### 10.1 Shopping categories

- Furniture.
- Appliances.
- Gadgets.
- Automation.
- Robots.
- Tools.
- Consumables.
- Decorations.
- Services.

### 10.2 Product presentation

Every product card must display:
- Product name.
- Image.
- Price.
- Category.
- Tier.
- Availability.
- Short description.

Detailed inspection must show:
- Functional benefits.
- Operating costs.
- Maintenance requirements.
- Placement requirements.
- Unlock requirements.
- Compatibility.
- Expected time savings where applicable.

### 10.3 Purchase confirmation

Before a significant purchase, show:
- Current balance.
- Purchase price.
- Remaining balance.
- Recurring operating cost.
- Installation requirements.

Confirmation must prevent accidental purchases.

Low-cost purchases may use a configurable simplified confirmation policy.

### 10.4 Product comparison

Comparison must use consistent metrics.

Players should be able to compare:
- Purchase cost.
- Operating cost.
- Capacity.
- Efficiency.
- Reliability.
- Maintenance.
- Task time.
- Automation capability.

Product claims must be based on real item configuration.

## 11. INVENTORY INTERFACE

Inventory displays:
- Owned portable items.
- Tools.
- Consumables.
- Upgrade components.
- Collectibles.
- Personal equipment.

Each item must display:
- Name.
- Quantity.
- Condition where applicable.
- Category.
- Usable actions.
- Transfer or storage options.

Placed furniture and installed appliances must not be incorrectly represented as available portable inventory.

## 12. PROPERTY MANAGEMENT

Property management provides:

- Property overview.
- Room navigation.
- Object placement.
- Furniture inventory.
- Appliance management.
- Power capacity.
- Network capacity.
- Storage capacity.
- Utility costs.
- Maintenance.
- Security.
- Property upgrades.

### 12.1 Placement mode

Placement mode must support:
- Object preview.
- Rotation.
- Position adjustment.
- Valid placement feedback.
- Invalid placement feedback.
- Surface and floor snapping where appropriate.
- Collision checks.
- Placement confirmation.
- Cancellation.

Invalid placement must not alter the world.

### 12.2 Placement feedback

Valid placement should be visually distinct from invalid placement.

The player must understand:
- Whether an object fits.
- Whether it blocks access.
- Whether it overlaps another object.
- Whether a connection is required.
- Whether the surface supports it.

### 12.3 Room organization

The interface may provide:
- Room labels.
- Room statistics.
- Object counts.
- Comfort summaries.
- Automation coverage.
- Power usage.

## 13. AUTOMATION MANAGEMENT

Automation management is a central gameplay interface.

It must show:
- Installed systems.
- Assigned tasks.
- Current activity.
- Operational state.
- Resource requirements.
- Maintenance condition.
- Operating cost.
- Efficiency.
- Recent results.
- Failure reports.

### 13.1 Automation controls

Players may:
- Activate or deactivate systems.
- Configure schedules.
- Set priorities.
- Assign compatible tasks.
- Define operating conditions.
- Configure resource limits.
- Review performance.
- Request maintenance.

### 13.2 Automation explanation

Every automated action must be understandable.

When a system fails to act, the interface must explain the actual reason.

Possible reasons:
- No available task.
- Missing resources.
- No power.
- Network unavailable.
- Device damaged.
- Maintenance required.
- Conflicting schedule.
- Invalid configuration.

## 14. ROBOT MANAGEMENT

Robot management displays:

- Robot name.
- Robot model.
- Condition.
- Battery or power state.
- Current task.
- Current location.
- Assigned task list.
- Storage capacity.
- Upgrade status.
- Maintenance requirements.

### 14.1 Robot commands

Available commands depend on robot capability.

Examples:
- Assign task.
- Return to charging station.
- Follow schedule.
- Enter standby.
- Return to maintenance.
- Inspect activity.
- Configure priorities.

Commands must be validated against actual robot capabilities.

### 14.2 World representation

Robot status must correspond to visible behavior.

If a robot is shown cleaning, it must actually be navigating and cleaning.

If it is charging, it must be at a valid charging location.

## 15. FINANCIAL INTERFACE

The financial interface must show:

- Current balance.
- Total assets.
- Recurring income.
- Recurring expenses.
- Business revenue.
- Business expenses.
- Net cash flow.
- Recent transactions.
- Upcoming payments.
- Outstanding obligations.

Graphs may show historical and projected values.

Projections must be clearly identified as estimates rather than guaranteed outcomes.

## 16. BUSINESS MANAGEMENT INTERFACE

Each business must provide:

- Business overview.
- Location.
- Operational state.
- Revenue.
- Expenses.
- Profit.
- Reputation.
- Demand.
- Equipment condition.
- Inventory.
- Automation.
- Upgrades.
- Recent events.

The player must be able to inspect why a business is profitable or losing money.

Business management should emphasize decisions rather than repetitive administrative clicking.

## 17. TASKS, CONTRACTS, AND OBJECTIVES

The objective interface must separate:

- Main objectives.
- Optional tasks.
- Contracts.
- Daily activities.
- Business objectives.
- Property improvements.
- Achievements.

Each objective must communicate:
- Description.
- Completion requirements.
- Reward.
- Progress.
- Deadline where applicable.
- Failure conditions where applicable.

Objectives must update from actual gameplay events.

## 18. NOTIFICATIONS AND EVENTS

Notifications must be useful and appropriately prioritized.

### 18.1 Notification categories

- Financial.
- Automation.
- Robot.
- Maintenance.
- Property.
- Business.
- Contract.
- Event.
- Achievement.
- System.

### 18.2 Notification priority

Critical:
- Major equipment failure.
- Financial payment failure.
- Serious property issue.
- Important contract deadline.

Important:
- Robot requires maintenance.
- Business performance problem.
- Automation interrupted.
- Upcoming payment.

Informational:
- Routine task completion.
- Minor income.
- New availability.
- Collection progress.

### 18.3 Notification controls

Players must be able to:
- Review notifications.
- Mark them read.
- Configure noncritical notification types.
- Mute selected notification sounds.
- Navigate to the affected system.

Critical notifications must not be silently discarded by ordinary filtering.

## 19. MAP AND WORLD NAVIGATION

The world map must display relevant locations and services.

Potential map information:
- Current property.
- Available businesses.
- Shops.
- Service providers.
- Contracts.
- Transportation points.
- Events.
- Points of interest.

Map markers must distinguish location categories.

The map must not display unavailable or undiscovered content as if it were accessible.

## 20. TIME AND SIMULATION CONTROLS

Where appropriate, players may:
- Pause.
- Resume.
- Accelerate simulation.
- Return to normal speed.

Time controls must not create inconsistent object, robot, business, or financial updates.

Important actions may require normal simulation speed.

## 21. SAVE AND LOAD INTERFACE

Save interface displays:
- Save name.
- Date and time.
- Playtime.
- Current property.
- Player progression.
- Financial summary.
- Save compatibility.

The interface must support:
- Manual save.
- Multiple save slots.
- Load.
- Rename.
- Delete with confirmation.
- Autosave status.

Saving must provide clear success or failure feedback.

## 22. SETTINGS

### 22.1 Graphics

- Resolution.
- Display mode.
- Quality preset.
- Texture quality.
- Shadow quality.
- Anti-aliasing.
- VSync.
- Frame rate limit.
- Upscaling options where supported.

### 22.2 Audio

- Master volume.
- Music volume.
- Effects volume.
- Dialogue volume.
- Interface volume.

### 22.3 Controls

- Keyboard rebinding.
- Controller rebinding where supported.
- Mouse sensitivity.
- Camera sensitivity.
- Inversion.
- Controller vibration.

### 22.4 Gameplay

- Tutorial guidance.
- Interaction assistance.
- HUD visibility.
- Camera behavior.
- Notification preferences.
- Simulation speed preferences.

Settings must persist across sessions.

## 23. ACCESSIBILITY

The game must support practical accessibility options.

Required targets:
- Adjustable subtitle size.
- Adjustable UI scale.
- Color-independent status indicators.
- High-contrast UI option.
- Remappable controls.
- Controller support.
- Camera sensitivity adjustment.
- Camera inversion.
- Separate volume controls.
- Reduced camera shake.
- Reduced motion options where practical.
- Hold-versus-toggle options for supported actions.
- Clear notification priority.
- Readable text at common display resolutions.

Critical information must never rely on color alone.

## 24. UI VISUAL DESIGN

### 24.1 Visual identity

The interface should communicate:
- Modern consumer technology.
- Comfortable domestic life.
- Exaggerated convenience culture.
- Approachable comedy.
- Premium presentation.

The UI must complement colorful stylized 3D environments.

### 24.2 Visual hierarchy

Use consistent:
- Typography.
- Spacing.
- Iconography.
- Button states.
- Panel structure.
- Color meaning.
- Interaction feedback.
- Notification behavior.

### 24.3 Interaction states

Every interactive control must support:
- Normal.
- Hover.
- Focus.
- Pressed.
- Selected.
- Disabled.
- Loading where applicable.
- Error where applicable.

### 24.4 Responsive layout

The interface must support common PC resolutions and aspect ratios.

It must remain usable on:
- 16:9 displays.
- 16:10 displays.
- Ultrawide displays.
- Windowed mode.
- Steam Deck-sized displays.

Text must not be clipped and essential controls must remain reachable.

## 25. AUDIO AND HAPTIC FEEDBACK

UI audio may include:
- Navigation.
- Selection.
- Confirmation.
- Cancellation.
- Purchase.
- Error.
- Notification.
- Achievement.
- Automation state change.

Sound must reinforce the action without becoming repetitive.

Controller vibration may communicate selected physical interactions and important feedback.

All feedback must respect accessibility and volume settings.

## 26. PERFORMANCE REQUIREMENTS

The UI must:
- Avoid unnecessary per-frame allocations.
- Avoid rebuilding entire screens for minor data changes.
- Use efficient list virtualization for large collections.
- Load product images and assets efficiently.
- Avoid blocking the main thread during large data operations.
- Release unused resources appropriately.

Opening a management interface must not cause significant frame-rate degradation.

## 27. UI DATA INTEGRITY

The UI must not become an independent source of truth.

All financial, ownership, task, property, and automation changes must be processed through the appropriate game services.

The UI must display authoritative state.

Invalid operations must be rejected by the underlying system even if a user interface control is accidentally activated.

## 28. TESTING REQUIREMENTS

Required tests:

1. Main menu navigation.
2. New game flow.
3. Continue and load.
4. Keyboard navigation.
5. Controller navigation.
6. Rebinding controls.
7. Interaction prompts.
8. Object inspection.
9. Product browsing.
10. Purchase confirmation.
11. Insufficient funds feedback.
12. Inventory state.
13. Placement validation.
14. Automation configuration.
15. Robot command validation.
16. Financial data accuracy.
17. Business data accuracy.
18. Notification priority.
19. Save/load UI.
20. Settings persistence.
21. Accessibility options.
22. Resolution and aspect-ratio behavior.
23. UI performance.
24. Error and disabled states.

## 29. DEFINITION OF DONE

The player experience and UI system is production-ready when:

- The complete launch-to-gameplay flow works.
- Main menu navigation works.
- Character controls are responsive.
- World interactions are discoverable.
- Object inspection reflects actual state.
- Shopping displays accurate catalog information.
- Purchases use the economy service.
- Inventory reflects actual ownership.
- Placement validates world constraints.
- Automation interfaces control real systems.
- Robot interfaces reflect actual behavior.
- Financial information is accurate.
- Business management reflects actual simulation data.
- Notifications reflect real events.
- Save and load work reliably.
- Settings persist.
- Accessibility requirements are implemented.
- Keyboard, mouse, and controller navigation work.
- Supported resolutions are tested.
- Automated tests pass.

---

## FINAL EXPERIENCE PRINCIPLE

The player should never feel that managing convenience is more inconvenient than the problems they are solving.

The world should be entertaining to inhabit, the interface should be easy to understand, and every major upgrade should visibly improve the player's lifestyle.

**The Game for Lazy People: Doing Nothing Has Never Been This Much Work.**
