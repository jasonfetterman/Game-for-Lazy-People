# THE GAME FOR LAZY PEOPLE
## Game Design Document
### Version 1.0 — Production Foundation

**Tagline:** Doing Nothing Has Never Been This Much Work.

**Project:** The Game for Lazy People  
**Genre:** 3D Comedy Idle-Tycoon / Life Simulation  
**Engine:** Unity 6.2 LTS  
**Platform:** PC / Steam first; console release considered after launch  
**Business Model:** Premium purchase  
**Target Launch Price:** $14.99 (provisional; subject to market validation)  
**Player Mode:** Single-player at launch  
**Visual Direction:** Colorful, stylized, exaggerated 3D comedy

---

# 1. PRODUCT VISION

The Game for Lazy People is a comedy-driven life simulation and tycoon game built around one central idea: the player works progressively harder to eliminate the need to work.

The player begins in a modest apartment with outdated furniture, inconvenient appliances, limited money, and a long list of everyday responsibilities. Almost everything requires direct effort. Cooking takes time. Cleaning takes time. Laundry takes time. Shopping requires leaving home. Repairs interrupt the day. Poor equipment makes ordinary activities unnecessarily difficult.

The player earns money, purchases better equipment, upgrades their property, and installs increasingly sophisticated automation systems. Eventually, appliances, robots, assistants, businesses, and interconnected systems handle most routine activities.

The comedy comes from the contrast between the player's increasingly ridiculous investments and their increasingly ambitious attempts to do absolutely nothing.

The game must be entertaining at three levels:

1. **Playing:** Activities, purchases, automation, events, and progression must create satisfying decisions.
2. **Watching:** Unexpected automation behavior, exaggerated situations, and visual comedy should make the game entertaining to watch.
3. **Sharing:** Properties, elaborate automation setups, expensive purchases, and funny failures should produce memorable screenshots and clips.

The long-term fantasy is to transform an inconvenient life into an absurdly luxurious, almost entirely automated lifestyle.

## 1.1 Core Design Promise

Every major purchase should eliminate, simplify, improve, or automate something the player previously had to do manually.

The player should be able to see the difference between their original lifestyle and their upgraded lifestyle.

## 1.2 Product Positioning

The game combines:
- Life simulation.
- Comedy simulation.
- Incremental progression.
- Property development.
- Automation and management.
- Light business and investment management.
- Collecting and customization.

It should not become a spreadsheet simulator. Management systems must produce visible consequences in the physical world.

---

# 2. DESIGN PILLARS

## 2.1 Convenience Is Progression

The primary progression system is the elimination of inconvenience.

Early gameplay emphasizes manual interaction. Middle gameplay introduces appliances and basic automation. Late gameplay introduces coordinated systems, robotic assistants, automated businesses, and high-end lifestyle technology.

Every major upgrade must provide a noticeable improvement.

## 2.2 Visible Transformation

The player's environment must visibly evolve.

The starter apartment should look and feel different from the upgraded apartment, penthouse, and mansion. Furniture, lighting, equipment, architecture, clutter, and automated activity should communicate progress without requiring the player to inspect statistics.

## 2.3 Comedy Through Systems

Comedy should emerge naturally from gameplay.

Examples:
- A robot vacuum repeatedly attempting to clean around an object it cannot move.
- A smart refrigerator ordering an unreasonable quantity of food.
- A luxury appliance announcing that it needs maintenance at the worst possible moment.
- A delivery robot becoming confused by a newly installed staircase.
- A player purchasing an expensive automation system to avoid a trivial activity.
- Multiple automated devices competing for limited space or access.

Comedy must not rely exclusively on scripted jokes. Systems should create unexpected but understandable situations.

## 2.4 Automation Must Be Meaningful

Automation is not simply a button that makes a task disappear.

Automated equipment has:
- Purchase costs.
- Installation requirements.
- Operating costs.
- Energy requirements.
- Maintenance requirements.
- Performance characteristics.
- Environmental limitations.
- Possible failures.
- Upgrade paths.

The player should make decisions about what to automate, when to automate it, and how much to invest.

## 2.5 Meaningful Economy

Money must have purpose.

The economy should create decisions between immediate comfort, long-term income, property upgrades, automation, maintenance, and investment.

The player should rarely feel that purchases are meaningless or that money accumulates without a reason.

## 2.6 Player Freedom

The player may manually complete activities, automate them, ignore them temporarily, or invest in systems that solve the problem differently.

The game should support multiple approaches rather than requiring one correct purchase sequence.

---

# 3. CORE GAMEPLAY LOOP

The fundamental gameplay loop is:

1. Discover an inconvenience, opportunity, or problem.
2. Decide whether to perform the activity manually or tolerate its consequences.
3. Earn money through available activities, work, business, or investments.
4. Purchase an upgrade, appliance, service, or automation device.
5. Install and configure the purchase.
6. Allow the system to perform its function.
7. Observe the results and collect the benefits.
8. Unlock larger opportunities and more advanced technology.
9. Improve the property and lifestyle.
10. Repeat at a larger scale.

## 3.1 Early Game

The player has limited money and basic equipment.

Typical activities:
- Prepare simple meals.
- Clean the apartment.
- Dispose of rubbish.
- Wash clothes.
- Purchase groceries.
- Rest and recover.
- Complete simple paid activities.
- Maintain inexpensive equipment.

The player directly performs most activities.

## 3.2 Mid Game

The player begins investing in convenience.

Typical upgrades:
- Dishwasher.
- Washing machine.
- Robot vacuum.
- Smart appliances.
- Automated grocery ordering.
- Basic security systems.
- Delivery services.
- Improved furniture.
- Better property.

The player begins choosing which inconveniences deserve investment.

## 3.3 Late Game

The player has access to advanced automation.

Typical upgrades:
- Multi-purpose household robots.
- Automated maintenance systems.
- Advanced kitchen systems.
- Smart property management.
- Automated business operations.
- Personal assistants.
- Integrated household control.
- High-end entertainment systems.

The player's challenge shifts from performing tasks to managing systems, expenses, upgrades, and unexpected events.

---

# 4. PLAYER EXPERIENCE AND CHARACTER

## 4.1 Player Character

The player controls a customizable character in a third-person 3D environment.

The character should support:
- Walking.
- Running.
- Jumping where appropriate.
- Interaction.
- Object inspection.
- Carrying selected objects.
- Using appliances.
- Sitting.
- Sleeping.
- Eating.
- Using entertainment equipment.
- Performing work and household activities.

Character customization should initially focus on practical options that can be expanded without changing the core gameplay.

## 4.2 Camera

The default camera is third-person.

The game may provide an optional management camera for property inspection, placement, and automation configuration.

Camera transitions must be smooth and should not disorient the player.

## 4.3 Needs and Condition

The character has a limited set of needs that create gameplay without becoming tedious.

Initial needs:
- Hunger.
- Energy.
- Hygiene.
- Comfort.
- Entertainment.

Each need must have:
- A readable state.
- A gameplay effect.
- At least one manual solution.
- At least one upgrade or automation opportunity.
- A clear visual or audio indication when important.

Needs must not become an excessive punishment system. The game is about convenience and comedy, not constant failure management.

---

# 5. PROPERTY AND WORLD PROGRESSION

Property progression provides the main physical representation of player success.

## 5.1 Starter Apartment

The starting property.

Characteristics:
- Small floor plan.
- Basic kitchen.
- Inexpensive furniture.
- Limited storage.
- Minimal automation.
- Low operating expenses.
- Visible wear and clutter.

The starter apartment must support the complete early gameplay loop.

## 5.2 Upgraded Apartment

The first substantial lifestyle upgrade.

Characteristics:
- More space.
- Better appliances.
- Improved furniture.
- More storage.
- Additional installation locations.
- Basic smart-home integration.

## 5.3 Luxury Penthouse

A major progression milestone.

Characteristics:
- Premium interior.
- Larger rooms.
- High-end appliances.
- Advanced entertainment.
- Expanded automation capacity.
- Increased operating costs.
- More customization options.

## 5.4 Mansion

The primary high-end residential property.

Characteristics:
- Multiple floors.
- Large rooms.
- Multiple bathrooms.
- Large kitchen.
- Dedicated entertainment areas.
- Garage and service areas.
- Advanced automation.
- Multiple robotic assistants.
- High maintenance and operating costs.

## 5.5 Future Expansion Properties

Private islands, futuristic residences, and experimental lifestyle environments are expansion-scale possibilities. They are not required for the first commercial release.

The initial release must prioritize a polished and complete residential progression experience.

---

# 6. INTERACTION FRAMEWORK

Every interactive object must use a consistent interaction framework.

An object may expose:
- Inspect.
- Use.
- Activate.
- Purchase.
- Configure.
- Upgrade.
- Repair.
- Clean.
- Move.
- Store.
- Remove.

Available actions depend on the object's type and state.

## 6.1 Interaction Feedback

When the player approaches an interactive object:
- The object should be identifiable.
- Available actions should be readable.
- Invalid actions should explain why they are unavailable.
- Successful actions should provide visible feedback.
- Long-running activities should communicate progress.

## 6.2 Example: Refrigerator

Initial refrigerator:
- Open door.
- Inspect contents.
- Take food.
- Store food.
- Close door.

Upgraded smart refrigerator:
- Track inventory.
- Recommend purchases.
- Automatically order selected groceries.
- Monitor food freshness.
- Report faults.
- Integrate with meal planning.

## 6.3 Example: Television

Basic television:
- Turn on and off.
- Select available entertainment.
- Consume electricity.

Advanced television:
- Smart recommendations.
- Multiple entertainment modes.
- Integration with home automation.
- Expanded customization.

## 6.4 Example: Bed

Basic bed:
- Sleep.
- Recover energy.

Advanced bed:
- Sleep scheduling.
- Automatic environmental adjustment.
- Comfort upgrades.
- Integrated wake-up routines.

## 6.5 Example: Dishwasher

Basic dishwasher:
- Accept dishes.
- Run a cleaning cycle.
- Require player interaction to load and unload.

Advanced dishwasher:
- Improved capacity.
- Reduced cycle time.
- Better efficiency.
- Optional integration with kitchen automation.

---

# 7. AUTOMATION SYSTEM

Automation is the defining gameplay feature.

## 7.1 Automation Categories

Initial categories:

**Cleaning**
- Robot vacuum.
- Robot mop.
- Automated rubbish collection.
- Surface-cleaning devices.

**Food**
- Smart refrigerator.
- Automated cooking equipment.
- Meal preparation systems.
- Grocery ordering.

**Laundry**
- Washing machines.
- Dryers.
- Automated folding equipment.
- Laundry management systems.

**Property**
- Smart lighting.
- Climate control.
- Security.
- Automated maintenance.

**Personal Assistance**
- General-purpose household robots.
- Delivery assistants.
- Maintenance robots.
- Personal service devices.

## 7.2 Automation Lifecycle

Every automation device follows a defined lifecycle:

1. Available for purchase.
2. Purchased.
3. Delivered.
4. Installed.
5. Configured.
6. Activated.
7. Performs assigned tasks.
8. Consumes operating resources.
9. Requires maintenance or service.
10. Can be upgraded, relocated, or replaced.

## 7.3 Autonomous Behavior

Automation devices must operate through understandable rules and world conditions.

A robot vacuum, for example, should:
- Detect dirty areas.
- Identify reachable locations.
- Navigate around obstacles.
- Avoid invalid or blocked routes.
- Return to its charging station.
- Report problems.
- Resume work when appropriate.

The robot should not teleport between locations or silently complete work that it could not physically perform.

## 7.4 Automation Performance

Automation performance may depend on:
- Device quality.
- Upgrade level.
- Battery or energy.
- Maintenance condition.
- Room layout.
- Obstacle density.
- Available resources.
- Installed supporting equipment.

## 7.5 Automation Failures

Failures are an important source of comedy and management decisions.

Possible failures:
- Low battery.
- Blocked path.
- Full storage.
- Mechanical fault.
- Network interruption.
- Incorrect configuration.
- Poor maintenance.
- Conflicting automation schedules.

Failures must be communicated clearly and must have reasonable recovery options.

---

# 8. ECONOMY

The primary currency is Credits.

## 8.1 Income Sources

Potential income sources:
- Paid activities.
- Part-time work.
- Remote work.
- Freelance tasks.
- Business ownership.
- Investments.
- Property-related income.
- Special opportunities and events.

## 8.2 Expenses

Potential expenses:
- Rent or property payments.
- Food.
- Utilities.
- Equipment purchases.
- Installation.
- Repairs.
- Maintenance.
- Service subscriptions.
- Business operating costs.
- Optional entertainment.

## 8.3 Purchase Categories

Items are divided into:
- Essential equipment.
- Comfort upgrades.
- Entertainment.
- Automation.
- Property improvements.
- Luxury purchases.
- Business equipment.

## 8.4 Economic Balancing

The economy must be tested using measurable metrics:
- Time required to afford the first automation device.
- Average income per gameplay hour.
- Operating expenses per property tier.
- Maintenance expense as a percentage of income.
- Time between meaningful purchases.
- Cost-to-benefit ratio of upgrades.
- Progression time between properties.

The first automation purchase should feel achievable but meaningful.

The player should have reasons to save, compare purchases, and choose between competing improvements.

Prices and income values are balancing variables, not fixed design promises. They must be tested through actual gameplay.

---

# 9. BUSINESS AND INVESTMENT

Business ownership provides a secondary progression path.

Potential business types:
- Vending operations.
- Small delivery services.
- Laundry services.
- Automated cleaning services.
- Food businesses.
- Property services.

Businesses must have:
- Purchase or startup cost.
- Operating expenses.
- Income generation.
- Upgrade options.
- Performance conditions.
- Possible events or interruptions.

Businesses should gradually become more automated as the player invests in equipment and management systems.

The initial release should implement a small number of complete business types rather than many superficial ones.

---

# 10. EVENTS AND COMEDY

Random and scheduled events keep the world from feeling static.

Event categories:
- Household incidents.
- Appliance failures.
- Delivery problems.
- Neighbor interactions.
- Unexpected expenses.
- Business opportunities.
- Automation accidents.
- Special rewards.
- Seasonal events.

Examples:
- A delivery arrives while the player is away.
- A robot becomes trapped under furniture.
- An appliance develops an expensive fault.
- A neighbor requests assistance.
- A smart device misunderstands a command.
- A business receives an unusually large order.

Each event must have:
- Trigger conditions.
- A clear presentation.
- Player choices where appropriate.
- Defined outcomes.
- Economic consequences when applicable.
- A cooldown or frequency rule to prevent repetition.

Comedy must remain understandable. Randomness should create surprises, not make the game feel unfair.

---

# 11. INVENTORY, SHOPPING, AND INSTALLATION

The player needs a reliable way to acquire and manage items.

Shopping must communicate:
- Item name.
- Description.
- Purchase price.
- Required space.
- Installation requirements.
- Operating costs.
- Benefits.
- Upgrade potential.

Purchased objects must have persistent ownership records.

Placement must validate:
- Available floor space.
- Collision.
- Room restrictions.
- Access requirements.
- Required connections.
- Installation conditions.

The game must prevent objects from being placed in unusable locations.

Items should support appropriate movement, storage, replacement, and sale behavior.

---

# 12. PROGRESSION AND UNLOCKS

Progression is based on financial capability, property development, equipment ownership, and completed milestones.

Unlock categories:
- New furniture.
- New appliances.
- New automation devices.
- New property options.
- New businesses.
- New services.
- New customization.
- New events.
- Advanced technology.

Unlock requirements must be visible before the player invests time toward them.

Progression should reward experimentation and different play styles.

The player should not be forced into a single upgrade path unless a requirement is essential to teach a core mechanic.

---

# 13. USER INTERFACE AND PRESENTATION

The interface should be clean, readable, and consistent with the game's comedic tone.

Primary interface elements:
- Credits display.
- Character condition.
- Interaction prompts.
- Current objectives.
- Notifications.
- Inventory.
- Shopping interface.
- Property management.
- Automation management.
- Business management.
- Settings and save management.

The interface must not replace the physical world.

Whenever practical, management should be connected to actual objects and locations. A player should be able to walk to a refrigerator and interact with it rather than relying exclusively on a disconnected menu.

Important feedback should use more than color alone. Text, icons, sound, and animation should reinforce critical information.

---

# 14. SAVE SYSTEM AND PERSISTENCE

The game must preserve the player's progress reliably.

Persistent data includes:
- Player identity and customization.
- Currency.
- Property ownership.
- Property configuration.
- Purchased items.
- Item placement.
- Automation ownership and configuration.
- Device condition.
- Inventory.
- Businesses.
- Progression and unlocks.
- Completed milestones.
- Relevant world state.

## 14.1 Save Slots

The system should support multiple save slots.

Each slot must display useful information such as:
- Player or campaign name.
- Current property.
- Current Credits.
- Playtime.
- Last save time.

## 14.2 Autosave

Autosave should occur at safe gameplay boundaries, including important purchases and progression milestones.

Autosave must not interrupt normal gameplay.

## 14.3 Data Safety

The save system must include:
- Versioned save data.
- Validation when loading.
- Safe handling of missing or invalid fields.
- Atomic save replacement where practical.
- Backup recovery.
- Clear error reporting.

A failed save must not silently destroy a previously valid save.

---

# 15. AUDIO

Audio is essential to the comedy and atmosphere.

Required audio categories:
- Music.
- Ambient room sounds.
- Character movement.
- Object interactions.
- Appliance operation.
- Robot movement and communication.
- Notifications.
- Purchase and reward feedback.
- Event sounds.
- Failure and warning sounds.

Audio should communicate state without overwhelming the player.

Robots and appliances should have distinct sound identities.

Music should support relaxed gameplay while allowing stronger cues during unusual events.

---

# 16. ART DIRECTION

The visual style is stylized, colorful, readable, and exaggerated.

The game should avoid photorealism as a production requirement. Strong silhouettes, expressive animation, recognizable objects, and clear visual feedback are more important.

## 16.1 Environment

The starter apartment should feel inexpensive, cramped, and imperfect.

Higher-tier properties should progressively communicate:
- More space.
- Better materials.
- Better lighting.
- Better equipment.
- More customization.
- Greater automation.

## 16.2 Characters and Robots

Characters and robots should have readable silhouettes and recognizable behavior.

Robot animation should communicate:
- Movement.
- Work.
- Charging.
- Confusion.
- Failure.
- Completion.
- Idle behavior.

## 16.3 Visual Comedy

Visual comedy may use:
- Exaggerated proportions.
- Unexpected object interactions.
- Physical reactions.
- Overly elaborate equipment.
- Dramatic notifications.
- Comically excessive upgrades.

The style should remain coherent across properties, objects, characters, and interface elements.

---

# 17. TECHNICAL ARCHITECTURE

## 17.1 Technology

- Unity 6.2.
- C#.
- Universal Render Pipeline.
- Unity Input System.
- Unity AI Navigation where appropriate.
- TextMeshPro.
- Unity Test Framework.
- ScriptableObjects for authored configuration data.

## 17.2 Architecture Principles

Systems must be modular and testable.

Core systems should have clearly defined responsibilities:
- Player control.
- Interaction.
- Character needs.
- Inventory.
- Items.
- Economy.
- Shopping.
- Property.
- Placement.
- Automation.
- AI behavior.
- Events.
- Progression.
- Save/load.
- User interface.
- Audio.

Systems should communicate through well-defined interfaces and events where appropriate.

Avoid unnecessary direct references between unrelated systems.

## 17.3 Data Design

Reusable content should be data-driven.

Items, appliances, automation devices, businesses, and upgrades should use stable identifiers.

Display names must not be used as persistent identifiers.

Balance values should be configurable without rewriting core gameplay code.

## 17.4 Performance

The initial performance target is 60 FPS at 1080p on a defined minimum PC specification.

This target must be validated through profiling on representative hardware.

Performance work should include:
- Object pooling where appropriate.
- Efficient update scheduling.
- Bounded simulation.
- Appropriate rendering settings.
- Controlled physics usage.
- Efficient navigation.
- Avoidance of unnecessary allocations.
- Scalable quality settings.

The game must remain responsive when multiple automation devices operate simultaneously.

## 17.5 Testing

Important systems require automated tests and in-game verification.

Testing must cover:
- Normal operation.
- Invalid actions.
- Resource shortages.
- Device failures.
- Object removal.
- Save and load.
- Progression.
- Economic calculations.
- Scene transitions.
- Long-running automation.

---

# 18. ACCESSIBILITY AND PLAYER OPTIONS

The game should provide:
- Adjustable audio levels.
- Adjustable mouse sensitivity.
- Key rebinding.
- Controller support.
- Subtitle options.
- Readable interface scaling.
- Color-independent status indicators.
- Camera options.
- Gameplay assistance options where practical.

Important information must not depend exclusively on small text or color differences.

---

# 19. INITIAL RELEASE CONTENT TARGETS

These are production targets to guide scope and planning. They are not a promise to ship incomplete content simply to meet a number.

Proposed initial content:
- 1 fully developed starter apartment.
- 1 upgraded apartment.
- 1 luxury penthouse.
- 1 mansion.
- Approximately 50 furniture and decoration items.
- Approximately 20 appliances and gadgets.
- Approximately 10 automation devices.
- Approximately 4 robot types.
- Approximately 6 business types.
- At least 30 distinct events.
- At least 50 achievements.

The quality of interactions, progression, and system integration takes priority over raw content count.

Every advertised item must have a meaningful gameplay purpose or customization value.

---

# 20. PRODUCTION MILESTONES

## Milestone 1: Design Foundation

Deliverables:
- Approved game design document.
- Core gameplay requirements.
- Technical architecture.
- Initial economy specification.
- Content scope.
- Production roadmap.

## Milestone 2: Core Prototype

Deliverables:
- Playable character.
- Camera.
- Interaction framework.
- One functional apartment.
- Basic needs.
- Basic Credits economy.
- One complete manual activity.

The prototype must demonstrate that the basic gameplay is enjoyable before major content production begins.

## Milestone 3: Automation Prototype

Deliverables:
- One purchasable automation device.
- Installation and configuration.
- Autonomous behavior.
- Operating costs.
- Failure and recovery.
- Visible improvement to the player's routine.

This milestone validates the game's defining mechanic.

## Milestone 4: Vertical Slice

Deliverables:
- Polished starter apartment.
- Complete early-game progression.
- Shopping and purchasing.
- Multiple appliances.
- Multiple automation devices.
- Save/load.
- Audio and visual feedback.
- Representative comedy events.

The vertical slice must demonstrate the quality expected from the final product.

## Milestone 5: Full Production

Deliverables:
- Remaining property tiers.
- Expanded equipment.
- Business systems.
- Progression.
- Events.
- Customization.
- UI and audio.
- Performance optimization.

## Milestone 6: Alpha

Requirements:
- All major gameplay systems implemented.
- Complete progression path.
- All critical content integrated.
- No major architectural placeholders.

## Milestone 7: Beta

Requirements:
- Feature complete.
- Content complete.
- Save migration tested.
- Performance tested.
- Usability tested.
- Bug fixing and balance.

## Milestone 8: Release Candidate

Requirements:
- No known release-blocking defects.
- Verified builds.
- Verified save behavior.
- Verified controls.
- Verified platform requirements.
- Final store assets and descriptions.
- Release checklist completed.

---

# 21. QUALITY REQUIREMENTS

A feature is not complete merely because a script compiles.

A production-ready feature must have:
1. A documented purpose.
2. Defined inputs and outputs.
3. Complete implementation.
4. Integration with relevant systems.
5. Player-facing feedback.
6. Normal gameplay testing.
7. Failure-condition testing.
8. Persistence testing when relevant.
9. Performance consideration.
10. Clear ownership and maintainability.
11. Updated documentation.
12. A Git checkpoint after verification.

No critical gameplay system should be represented by an empty class, fake interaction, nonfunctional button, placeholder behavior, or misleading UI.

Temporary prototype code must be clearly isolated and must not be mistaken for finished production functionality.

---

# 22. COMMERCIAL STRATEGY

The initial commercial target is a premium PC release on Steam.

The provisional price target is $14.99.

The price must be evaluated against:
- Comparable games.
- Demonstrated content depth.
- Production quality.
- Replayability.
- Player feedback.
- Store-page conversion.
- Market conditions.

The game should have a strong trailer showing the transformation from manual household chores to ridiculous high-end automation.

Marketing should emphasize:
- The convenience progression fantasy.
- Funny autonomous systems.
- Property transformations.
- Unexpected automation behavior.
- Player-created situations.
- Clear before-and-after gameplay.

A playable demo should be considered once the core loop and automation prototype are stable.

Multiplayer is not part of the initial release requirement. It may be evaluated after the single-player game is commercially and technically established.

---

# 23. SUCCESS CRITERIA

The game is succeeding as a product when:
- Players understand the core loop quickly.
- Manual activities are satisfying enough to support early progression.
- Automation feels like a meaningful reward.
- Property upgrades create visible excitement.
- The economy supports interesting decisions.
- Comedy emerges naturally from gameplay.
- Players want to continue improving their lifestyle.
- The game performs reliably.
- Save data is dependable.
- The experience is polished enough to justify its price.

The game must be fun before it is large.

A smaller, coherent, polished experience is preferable to a massive collection of shallow systems.

---

# 24. FINAL DESIGN PRINCIPLE

The player begins with a small apartment, limited money, and too many responsibilities.

They work, save, purchase, upgrade, automate, and expand.

Eventually, they own an absurdly sophisticated lifestyle in which machines perform the work, systems manage the machines, and the player has to decide what to do with all the free time.

The central joke is that achieving a life of complete laziness requires an extraordinary amount of planning, spending, and management.

**The Game for Lazy People: Doing Nothing Has Never Been This Much Work.**
