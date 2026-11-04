# THE GAME FOR LAZY PEOPLE
# CONTENT CATALOG SPECIFICATION
## Version 1.0 — Production Content Definition

---

## 1. PURPOSE

This document defines the initial production content catalog for The Game for Lazy People.

It establishes the items, equipment, automation devices, robots, properties, businesses, services, upgrades, and unlockable content that populate the game.

The catalog is designed around one central fantasy:

**Build an increasingly ridiculous lifestyle in which every inconvenience can eventually be solved by purchasing something, installing something, or making something else do the work.**

The catalog must support a complete playable progression from a poorly equipped starter apartment to an advanced autonomous lifestyle empire.

All catalog entries must use unique identifiers and structured data. Display names are not identifiers.

## 2. CONTENT DESIGN PRINCIPLES

Every content item must satisfy at least one purpose:

- Provide a functional gameplay benefit.
- Remove or reduce a repetitive task.
- Improve the player's living environment.
- Enable a new automation capability.
- Generate or improve income.
- Unlock a new gameplay opportunity.
- Support player expression and customization.
- Deliver comedy or memorable interactions.

Functional products must have actual effects in the simulation.

Decorative products must have meaningful placement, appearance, collection, property-value, or satisfaction effects.

The catalog must not contain products that exist only as empty menu entries.

## 3. CATALOG IDENTIFICATION

### 3.1 Identifier format

Use stable identifiers:

- `FURN_` for furniture.
- `APPL_` for appliances.
- `GADG_` for gadgets.
- `AUTO_` for automation equipment.
- `ROBO_` for robots.
- `TOOL_` for tools.
- `CONS_` for consumables.
- `PROP_` for properties.
- `BIZ_` for businesses.
- `SERV_` for services.
- `UPG_` for upgrades.
- `COSM_` for cosmetics.

Examples:

- `FURN_STARTER_BED`
- `APPL_BASIC_REFRIGERATOR`
- `AUTO_SMART_CLEANING_SYSTEM`
- `ROBO_HOUSEHOLD_ASSISTANT`
- `PROP_STARTER_APARTMENT`

Identifiers must never be recycled after release.

### 3.2 Required catalog fields

Every catalog entry must define:

- Unique ID.
- Display name.
- Description.
- Content category.
- Content tier.
- Purchase price.
- Unlock requirements.
- World prefab reference, where applicable.
- Icon or presentation asset.
- Functional capabilities.
- Placement requirements.
- Operating expenses, where applicable.
- Maintenance requirements, where applicable.
- Upgrade compatibility.
- Sale or refund rules.
- Content availability.

### 3.3 Content states

Items can be:

- LOCKED
- AVAILABLE
- OWNED
- INSTALLED
- ACTIVE
- INACTIVE
- DAMAGED
- UNDER_MAINTENANCE
- SOLD
- RETIRED

State transitions must be validated by the relevant gameplay system.

## 4. STARTER APARTMENT CATALOG

The starter apartment must contain enough equipment to support the initial gameplay loop without giving the player advanced conveniences.

### 4.1 Included starter furniture

| Catalog ID | Item | Functional purpose |
|---|---|---|
| FURN_STARTER_BED | Basic Bed | Rest and recovery |
| FURN_STARTER_NIGHTSTAND | Small Nightstand | Storage |
| FURN_STARTER_TABLE | Small Table | Surface placement |
| FURN_STARTER_CHAIR | Basic Chair | Seating |
| FURN_STARTER_SOFA | Worn Sofa | Seating and comfort |
| FURN_STARTER_WARDROBE | Basic Wardrobe | Clothing storage |
| FURN_STARTER_SHELF | Small Shelf | Storage and decoration |
| FURN_STARTER_DESK | Compact Desk | Work surface |

### 4.2 Included starter appliances

| Catalog ID | Item | Functional purpose |
|---|---|---|
| APPL_STARTER_REFRIGERATOR | Basic Refrigerator | Food storage |
| APPL_STARTER_STOVE | Basic Stove | Food preparation |
| APPL_STARTER_MICROWAVE | Basic Microwave | Quick food preparation |
| APPL_STARTER_WASHER | Basic Washing Machine | Laundry |
| APPL_STARTER_SHOWER | Basic Shower | Hygiene |
| APPL_STARTER_LIGHTING | Basic Lighting | Room illumination |

### 4.3 Starter equipment condition

Starter equipment should be functional but not premium.

Some items may have:
- Lower efficiency.
- Limited capacity.
- Greater maintenance frequency.
- Slower operation.
- Less favorable appearance.

Starter equipment must not be deliberately unreliable to the point of frustrating the player.

## 5. FURNITURE CATALOG

### 5.1 Living room furniture

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| FURN_SOFA_STANDARD | Standard Sofa | Basic | 250 |
| FURN_SOFA_SECTIONAL | Sectional Sofa | Improved | 850 |
| FURN_SOFA_LUXURY | Luxury Sofa | Premium | 2,500 |
| FURN_RECLINER | Powered Recliner | Improved | 1,200 |
| FURN_COFFEE_TABLE | Coffee Table | Basic | 180 |
| FURN_MEDIA_CONSOLE | Media Console | Basic | 350 |
| FURN_TV_WALL | Television Wall Unit | Improved | 950 |
| FURN_BOOKCASE | Bookcase | Basic | 300 |
| FURN_DISPLAY_CASE | Display Case | Improved | 750 |
| FURN_MASSAGE_CHAIR | Massage Chair | Premium | 3,500 |

### 5.2 Bedroom furniture

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| FURN_BED_STANDARD | Standard Bed | Basic | 400 |
| FURN_BED_PREMIUM | Premium Bed | Improved | 1,200 |
| FURN_BED_LUXURY | Luxury Bed | Premium | 4,000 |
| FURN_BED_SMART | Smart Adjustable Bed | Advanced | 7,500 |
| FURN_DRESSER | Dresser | Basic | 250 |
| FURN_BEDSIDE_CABINET | Bedside Cabinet | Basic | 150 |
| FURN_WARDROBE_LARGE | Large Wardrobe | Improved | 650 |
| FURN_WALKIN_STORAGE | Walk-in Storage System | Premium | 2,500 |

### 5.3 Office furniture

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| FURN_OFFICE_DESK | Office Desk | Basic | 350 |
| FURN_EXECUTIVE_DESK | Executive Desk | Premium | 2,000 |
| FURN_OFFICE_CHAIR | Ergonomic Office Chair | Improved | 750 |
| FURN_EXECUTIVE_CHAIR | Executive Chair | Premium | 1,800 |
| FURN_MONITOR_STAND | Monitor Stand | Basic | 125 |
| FURN_CONFERENCE_TABLE | Conference Table | Premium | 2,500 |

### 5.4 Kitchen and dining furniture

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| FURN_DINING_TABLE_SMALL | Small Dining Table | Basic | 300 |
| FURN_DINING_TABLE_LARGE | Large Dining Table | Improved | 850 |
| FURN_DINING_CHAIR | Dining Chair | Basic | 90 |
| FURN_KITCHEN_ISLAND | Kitchen Island | Premium | 2,500 |
| FURN_KITCHEN_CABINET | Kitchen Cabinet | Basic | 200 |
| FURN_PANTRY_UNIT | Pantry Storage | Improved | 650 |

### 5.5 Decoration and comfort

Decorative content includes:
- Paintings.
- Wall clocks.
- Plants.
- Rugs.
- Curtains.
- Lamps.
- Sculptures.
- Posters.
- Collectibles.
- Wall decorations.
- Decorative shelving.
- Seasonal decorations.

Decorations can influence:
- Room appeal.
- Property presentation.
- Collection progress.
- Selected event outcomes.
- Player satisfaction.

Decorations must not create artificial financial benefits unless explicitly configured.

## 6. APPLIANCE CATALOG

### 6.1 Cleaning appliances

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| APPL_VACUUM_BASIC | Basic Vacuum | Basic | 250 |
| APPL_VACUUM_PREMIUM | Premium Vacuum | Improved | 850 |
| APPL_ROBOT_VACUUM | Robot Vacuum | Advanced | 2,500 |
| APPL_STEAM_CLEANER | Steam Cleaner | Improved | 950 |
| APPL_FLOOR_CLEANER | Automatic Floor Cleaner | Advanced | 3,500 |
| APPL_WINDOW_CLEANER | Window Cleaning Device | Advanced | 2,800 |

### 6.2 Laundry appliances

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| APPL_WASHER_STANDARD | Standard Washer | Basic | 650 |
| APPL_WASHER_PREMIUM | Premium Washer | Improved | 1,500 |
| APPL_WASHER_SMART | Smart Washer | Advanced | 3,500 |
| APPL_DRYER_STANDARD | Standard Dryer | Basic | 600 |
| APPL_DRYER_SMART | Smart Dryer | Advanced | 3,000 |
| APPL_FOLDING_MACHINE | Automatic Folding Machine | Premium | 8,000 |

### 6.3 Kitchen appliances

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| APPL_REFRIGERATOR_STANDARD | Standard Refrigerator | Basic | 500 |
| APPL_REFRIGERATOR_SMART | Smart Refrigerator | Advanced | 3,000 |
| APPL_DISHWASHER | Dishwasher | Improved | 1,200 |
| APPL_DISHWASHER_SMART | Smart Dishwasher | Advanced | 3,500 |
| APPL_COFFEE_MACHINE | Automatic Coffee Machine | Improved | 850 |
| APPL_COFFEE_MACHINE_LUXURY | Premium Coffee System | Premium | 3,000 |
| APPL_MULTICOOKER | Programmable Multicooker | Improved | 650 |
| APPL_SMART_OVEN | Smart Oven | Advanced | 3,500 |
| APPL_MEAL_PRINTER | Automated Meal Preparation Device | Premium | 12,000 |

### 6.4 Comfort appliances

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| APPL_AIR_CONDITIONER | Air Conditioner | Basic | 900 |
| APPL_SMART_THERMOSTAT | Smart Thermostat | Improved | 500 |
| APPL_AIR_PURIFIER | Air Purifier | Improved | 700 |
| APPL_HUMIDIFIER | Smart Humidifier | Basic | 250 |
| APPL_AUTOMATIC_BLINDS | Automatic Window Blinds | Advanced | 2,000 |
| APPL_SMART_LIGHTING | Smart Lighting System | Improved | 750 |

## 7. GADGET CATALOG

Gadgets provide small but meaningful conveniences.

### 7.1 Personal gadgets

- Smartphone.
- Smartwatch.
- Wireless earbuds.
- Voice assistant.
- Digital assistant display.
- Portable entertainment device.
- Smart glasses.
- Personal charging station.

### 7.2 Household gadgets

- Smart plugs.
- Motion sensors.
- Smart door locks.
- Leak detectors.
- Environmental sensors.
- Automated dispensers.
- Smart waste bin.
- Package notification system.
- Remote appliance controller.

### 7.3 Advanced gadgets

- Household command tablet.
- Whole-home monitoring hub.
- Predictive maintenance scanner.
- AI scheduling terminal.
- Autonomous shopping interface.
- Integrated lifestyle control station.

Every functional gadget must connect to an actual supported gameplay capability.

## 8. AUTOMATION CATALOG

Automation equipment is the primary long-term convenience progression.

### 8.1 Cleaning automation

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| AUTO_ROBOT_VACUUM | Autonomous Vacuum System | Basic | 1,500 |
| AUTO_FLOOR_CLEANER | Autonomous Floor Cleaning System | Improved | 3,500 |
| AUTO_WINDOW_CLEANER | Autonomous Window Cleaning System | Improved | 4,000 |
| AUTO_FULL_CLEANING | Integrated Cleaning Network | Advanced | 12,000 |

### 8.2 Laundry automation

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| AUTO_SMART_LAUNDRY | Smart Laundry Controller | Basic | 1,500 |
| AUTO_LAUNDRY_SORTER | Automatic Laundry Sorter | Improved | 3,000 |
| AUTO_LAUNDRY_FOLDING | Automatic Folding System | Advanced | 8,000 |
| AUTO_LAUNDRY_NETWORK | Integrated Laundry Network | Premium | 15,000 |

### 8.3 Kitchen automation

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| AUTO_MEAL_SCHEDULER | Meal Scheduling System | Basic | 1,000 |
| AUTO_FOOD_INVENTORY | Smart Food Inventory | Improved | 2,500 |
| AUTO_MEAL_PREPARATION | Automated Meal Preparation | Advanced | 10,000 |
| AUTO_KITCHEN_NETWORK | Integrated Kitchen Network | Premium | 20,000 |

### 8.4 Household management automation

| Catalog ID | Item | Tier | Target price |
|---|---|---|---:|
| AUTO_HOME_CONTROLLER | Household Controller | Basic | 2,000 |
| AUTO_SCHEDULE_MANAGER | Autonomous Schedule Manager | Improved | 4,000 |
| AUTO_MAINTENANCE_MONITOR | Predictive Maintenance System | Advanced | 7,500 |
| AUTO_HOME_NETWORK | Integrated Home Automation Network | Premium | 25,000 |
| AUTO_HOME_AI | Autonomous Household Intelligence | Luxury | 50,000 |

## 9. ROBOT CATALOG

Robots are physical autonomous agents. Each must exist in the game world and execute visible behaviors.

### 9.1 Household robots

| Catalog ID | Robot | Tier | Target price |
|---|---|---|---:|
| ROBO_CLEANER_BASIC | Dusty Cleaning Robot | Basic | 1,500 |
| ROBO_CLEANER_PREMIUM | Sweep Pro | Improved | 3,500 |
| ROBO_UTILITY | Utility Carrier Robot | Improved | 3,000 |
| ROBO_LAUNDRY | Laundry Assistant | Advanced | 6,000 |
| ROBO_KITCHEN | Kitchen Assistant | Advanced | 8,000 |
| ROBO_MAINTENANCE | Maintenance Assistant | Premium | 12,000 |
| ROBO_HOUSEHOLD | Household Assistant | Premium | 18,000 |
| ROBO_AUTONOMOUS | Autonomous Lifestyle Manager | Luxury | 30,000 |

### 9.2 Robot capabilities

A robot may support:
- Navigation.
- Object interaction.
- Task selection.
- Task execution.
- Inventory transport.
- Charging.
- Maintenance.
- Fault reporting.
- Scheduling.
- Multi-step task planning.

Robots must obey navigation and interaction constraints.

A robot must not claim to complete a task if the world interaction did not actually occur.

### 9.3 Robot customization

Robots may support:
- Cosmetic shells.
- Color schemes.
- Tool attachments.
- Battery upgrades.
- Storage upgrades.
- Navigation upgrades.
- Task capacity upgrades.
- Maintenance upgrades.
- Personality settings.

Cosmetic customization must not secretly change gameplay statistics.

## 10. TOOLS AND CONSUMABLES

### 10.1 Manual tools

- Cleaning supplies.
- Mop.
- Broom.
- Hand vacuum.
- Repair toolkit.
- Screwdriver set.
- Portable ladder.
- Garden tools.
- Laundry basket.
- Storage containers.

Tools provide manual alternatives to automation and may be required for certain repairs.

### 10.2 Consumables

- Food.
- Cleaning products.
- Laundry detergent.
- Replacement filters.
- Batteries.
- Robot maintenance kits.
- Appliance repair components.
- Personal hygiene products.

Consumables must have clear inventory and replenishment behavior.

## 11. PROPERTY CATALOG

### 11.1 Residential properties

| Catalog ID | Property | Target value |
|---|---|---:|
| PROP_STARTER_APARTMENT | Starter Apartment | Rental |
| PROP_IMPROVED_APARTMENT | Improved Apartment | 35,000 |
| PROP_PREMIUM_APARTMENT | Premium Apartment | 80,000 |
| PROP_PENTHOUSE | Luxury Penthouse | 225,000 |
| PROP_SUBURBAN_HOUSE | Suburban House | 450,000 |
| PROP_LARGE_HOUSE | Large Residential House | 650,000 |
| PROP_MANSION | Luxury Mansion | 1,200,000 |

### 11.2 Property capabilities

Properties define:
- Floor plan.
- Rooms.
- Placement capacity.
- Storage capacity.
- Power capacity.
- Network capacity.
- Automation connection capacity.
- Utility expenses.
- Maintenance requirements.
- Neighborhood.
- Property tier.
- Available upgrades.

### 11.3 Property expansion

Possible upgrades:
- Additional storage.
- Improved electrical infrastructure.
- Smart networking.
- Expanded kitchen.
- Dedicated robot charging area.
- Workshop.
- Home office.
- Entertainment room.
- Security system.
- Garden.
- Pool.
- Garage.
- Guest suite.

## 12. BUSINESS CATALOG

### 12.1 Initial business types

| Catalog ID | Business | Establishment cost |
|---|---|---:|
| BIZ_VENDING | Vending Operation | 5,000 |
| BIZ_LAUNDRY | Automated Laundry Service | 12,000 |
| BIZ_DELIVERY | Delivery Operation | 20,000 |
| BIZ_CLEANING | Cleaning Service | 30,000 |
| BIZ_RETAIL | Automated Retail Shop | 45,000 |
| BIZ_PROPERTY_MANAGEMENT | Property Management Service | 75,000 |

### 12.2 Business operating requirements

Every business must define:
- Location.
- Establishment cost.
- Operating costs.
- Required equipment.
- Staffing or automation capacity.
- Inventory requirements.
- Customer demand model.
- Revenue model.
- Maintenance.
- Upgrade paths.
- Reputation effects.
- Shutdown conditions.

### 12.3 Business expansion

Expansion opportunities:
- Additional service locations.
- More delivery capacity.
- Improved equipment.
- Automated customer support.
- Expanded inventory.
- Predictive scheduling.
- Multi-location management.
- Autonomous business management.

## 13. SERVICES CATALOG

The player may purchase services instead of owning equipment.

Services include:
- Food delivery.
- Grocery delivery.
- Laundry pickup.
- Cleaning service.
- Maintenance callout.
- Appliance repair.
- Robot repair.
- Property management.
- Subscription entertainment.
- Transportation.
- Personal assistance.

Services must show:
- Price.
- Delivery or completion time.
- Scope.
- Recurring status.
- Cancellation rules.
- Quality level.
- Any additional charges.

Services provide an important alternative for players who prefer spending money over managing equipment.

## 14. UPGRADE CATALOG

Upgrades must modify actual system behavior.

### 14.1 Appliance upgrades

- Energy efficiency.
- Capacity.
- Operation speed.
- Reliability.
- Maintenance interval.
- Connectivity.
- Noise reduction.

### 14.2 Automation upgrades

- Task efficiency.
- Scheduling intelligence.
- Navigation capability.
- Multi-device coordination.
- Fault detection.
- Resource optimization.
- Operating cost reduction.

### 14.3 Robot upgrades

- Battery capacity.
- Movement speed.
- Storage capacity.
- Tool compatibility.
- Navigation accuracy.
- Task prioritization.
- Maintenance efficiency.

### 14.4 Property upgrades

- Electrical capacity.
- Network coverage.
- Storage.
- Room functionality.
- Security.
- Environmental comfort.
- Automation infrastructure.

Upgrades must validate compatibility and ownership.

## 15. COSMETIC AND COLLECTION CONTENT

Cosmetic content supports personalization and long-term collection.

Content categories:
- Furniture skins.
- Appliance finishes.
- Robot appearances.
- Wall decorations.
- Flooring.
- Wall materials.
- Lighting styles.
- Clothing.
- Accessories.
- Seasonal items.
- Trophy displays.

Cosmetics must be distinguishable from functional upgrades.

If cosmetic purchases affect gameplay, those effects must be explicitly documented.

## 16. COMEDY CONTENT

Comedy is a core part of the game's identity.

Examples of content and interactions:
- A smart bin that complains when it is full.
- A robot that proudly announces a two-cent cleaning efficiency improvement.
- A luxury automated coffee machine with an unnecessarily complicated startup sequence.
- A premium chair that requires an installation appointment.
- A household AI that schedules a meeting to discuss why the player is doing nothing.
- A robot that politely refuses to work until its maintenance request is acknowledged.
- A smart refrigerator that sends increasingly dramatic food inventory warnings.
- A subscription service that charges extra to stop sending notifications.
- An executive relaxation package with an extensive application process.
- A home management AI that reports the player has achieved maximum inactivity.

Comedy must be implemented through authored dialogue, animation, sound, UI, and event systems. It must not rely solely on random text.

## 17. CATALOG SCALE AND INITIAL CONTENT TARGETS

The initial release should target:

| Content category | Initial target |
|---|---:|
| Furniture and decorations | 50 |
| Appliances | 20 |
| Gadgets | 20 |
| Automation devices | 10 |
| Robots | 4 |
| Manual tools | 10 |
| Consumable types | 15 |
| Residential properties | 6 |
| Business types | 6 |
| Service types | 10 |
| Upgrade families | 20 |
| Achievement definitions | 50 |
| Major events | 30 |

These are content targets, not permission to ship unfinished entries.

Each released item must have:
- Complete data.
- Valid assets.
- Functional behavior where applicable.
- Tested purchase and ownership behavior.
- Correct save/load behavior.
- Correct UI presentation.
- Appropriate audio and feedback.

## 18. CONTENT PRODUCTION PIPELINE

Every catalog item passes through:

1. Design approval.
2. Economic review.
3. Asset creation.
4. Prefab construction.
5. Functional implementation.
6. UI integration.
7. Audio integration.
8. Catalog data validation.
9. Gameplay testing.
10. Performance testing.
11. Final approval.

No item enters the release catalog without passing its required checks.

## 19. ASSET AND PREFAB REQUIREMENTS

World objects must use reusable prefabs.

Each prefab must define:
- Correct scale.
- Pivot.
- Collider configuration.
- Interaction points.
- Placement bounds.
- Material assignments.
- LOD configuration where appropriate.
- Shadow settings.
- Audio hooks.
- Functional component references.
- Save identity support.

Functional objects must expose their supported capabilities through explicit interfaces or data-driven capability definitions.

Catalog entries must not directly manipulate unrelated gameplay systems.

## 20. CATALOG DATA VALIDATION

Automated validation must reject:
- Duplicate IDs.
- Empty display names.
- Missing descriptions.
- Negative prices.
- Invalid unlock requirements.
- Missing required prefabs.
- Missing required icons.
- Invalid capability references.
- Invalid upgrade compatibility.
- Missing operating cost configuration.
- Invalid content states.
- Circular unlock dependencies.
- Broken asset references.

The editor must provide a catalog validation report identifying the exact entry and failure.

## 21. SAVE AND OWNERSHIP REQUIREMENTS

The catalog defines product information. The save system stores player ownership and runtime condition separately.

Save data must include:
- Owned item ID.
- Instance ID.
- Property assignment.
- Placement state.
- Upgrade state.
- Condition.
- Operational state.
- Customization.
- Inventory quantity where relevant.

Loading must resolve catalog IDs against the active catalog version.

Missing or retired entries must be handled safely without corrupting the entire save.

## 22. CONTENT TESTING REQUIREMENTS

Required tests:

1. Every catalog ID is unique.
2. Every purchasable item has a valid price.
3. Every item has valid display data.
4. Every functional object has a valid capability definition.
5. Every placeable object has valid placement data.
6. Every appliance can enter its expected operating states.
7. Every robot can execute its supported task types.
8. Every automation system produces its documented effects.
9. Every property supports its documented capacity.
10. Every business has a valid financial model.
11. Every service completes or fails with a valid outcome.
12. Every upgrade validates compatibility.
13. Every owned item persists through save/load.
14. Every retired item is handled safely.
15. Every content unlock has valid prerequisites.

## 23. DEFINITION OF DONE

The content catalog is production-ready when:
- All required content IDs are defined.
- Every entry has complete data.
- Prices match the economy specification.
- Unlock rules are validated.
- Functional entries have implemented behavior.
- Prefabs are production-ready.
- UI can display catalog information.
- Purchasing and ownership work.
- Save/load works.
- Content validation passes.
- Content-specific tests pass.
- Performance requirements are satisfied.

---

## FINAL CONTENT DESIGN PRINCIPLE

Every product must represent a meaningful choice.

The player should be able to look at an inconvenience, identify a product or service that solves it, purchase that solution, and see the world become easier to manage.

The catalog is not simply a list of things to buy.

**It is the player's growing arsenal against effort.**

**The Game for Lazy People: Doing Nothing Has Never Been This Much Work.**
