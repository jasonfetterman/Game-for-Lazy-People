# THE GAME FOR LAZY PEOPLE
# ECONOMY AND PROGRESSION SPECIFICATION
## Version 1.0 — Production Balancing Specification

---

## 1. PURPOSE

This document defines the complete economic and progression framework for The Game for Lazy People.

The economy must support the central game fantasy:

**The player gradually spends money to eliminate work, inconvenience, repetitive tasks, and responsibility.**

The economy must create meaningful decisions without becoming unnecessarily punishing. Players should always understand:
- How they earn money.
- What they spend money on.
- What an upgrade actually improves.
- How much time an investment saves.
- How automation changes their financial position.
- What opportunities become available next.

All initial values in this document are balancing targets. They must be stored in configurable game data rather than scattered through gameplay scripts.

## 2. ECONOMIC DESIGN PRINCIPLES

### 2.1 Core principles

1. Money must have meaningful uses throughout the game.
2. Manual work must be useful early and progressively less necessary.
3. Automation must provide measurable benefits.
4. Expensive purchases must feel like meaningful milestones.
5. Players must be able to recover from poor financial decisions.
6. Recurring expenses must create planning opportunities, not endless frustration.
7. Passive income must never make the entire game irrelevant.
8. Higher-tier properties must introduce new opportunities, not merely larger numbers.
9. Every major purchase must communicate its expected benefit.
10. The economy must remain understandable without requiring spreadsheets.

### 2.2 Economic progression fantasy

The intended progression is:

- Early game: The player works to afford basic conveniences.
- Early-mid game: The player purchases appliances and basic automation.
- Mid game: The player manages a home with several automated systems.
- Late-mid game: The player earns income through businesses and investments.
- Late game: The player operates an increasingly autonomous lifestyle.
- Endgame: The player builds an absurdly sophisticated convenience empire.

The player should gradually transition from performing work to designing systems that perform work.

## 3. CURRENCY SYSTEM

### 3.1 Primary currency

Currency name: Credits

Credits are used for:
- Furniture and decoration.
- Appliances.
- Gadgets.
- Automation devices.
- Robots.
- Property purchases.
- Property improvements.
- Business establishment.
- Business upgrades.
- Maintenance.
- Services.
- Optional events and entertainment.

### 3.2 Currency rules

- Credits are stored as whole-number values.
- Transactions must be validated by the economy service.
- A purchase cannot create a negative balance.
- Refunds must reference the original transaction.
- Transactions must be recorded in the player's financial history.
- UI balances must reflect authoritative economy state.
- Save files must preserve balances and transaction records.
- Currency calculations must use integer-safe arithmetic.

### 3.3 Financial history

Every transaction records:
- Unique transaction ID.
- Transaction category.
- Transaction description.
- Amount.
- Balance before transaction.
- Balance after transaction.
- In-game timestamp.
- Associated item, property, business, or service.
- Transaction result.

Transaction categories:
- TASK_INCOME
- CONTRACT_INCOME
- BUSINESS_INCOME
- INVESTMENT_INCOME
- PURCHASE
- PROPERTY_EXPENSE
- UTILITY_EXPENSE
- FOOD_EXPENSE
- MAINTENANCE_EXPENSE
- SERVICE_EXPENSE
- EVENT_REWARD
- REFUND
- TAX
- OTHER

## 4. GAME TIME AND ECONOMIC PERIODS

### 4.1 Initial time scale

Target simulation scale:

| Game time | Real time |
|---|---:|
| 1 game minute | 1 real second |
| 1 game hour | 1 real minute |
| 1 game day | 24 real minutes |
| 1 game week | 2 hours 48 minutes |
| 1 game month | 12 hours |

The simulation clock must support:
- Normal speed.
- Accelerated speed.
- Paused simulation where appropriate.
- Offline progression calculations.
- Event-driven time advancement.

Time scaling must be centralized. Individual economic systems must never independently manipulate the game clock.

### 4.2 Billing periods

Recurring expenses are calculated using game time.

Daily expenses:
- Food allowance.
- Basic utilities.
- Consumables.

Weekly expenses:
- Selected subscriptions.
- Services.
- Some maintenance contracts.

Monthly expenses:
- Rent or property financing.
- Insurance.
- Property-related obligations.
- Business operating costs where configured.

Players must receive advance notifications before major payments.

## 5. STARTING FINANCIAL POSITION

### 5.1 New game allocation

Target starting balance: 1,500 Credits.

The player begins with:
- One basic apartment.
- Basic furniture.
- A basic bed.
- A basic refrigerator.
- A basic cooking appliance.
- A manual cleaning setup.
- A basic smartphone.
- No owned robots.
- No advanced automation.
- No established business.
- No investment portfolio.

The starter property is initially rented.

### 5.2 Starting economic condition

The player should have enough money to experiment with early purchases but not enough to skip the opening progression.

Starting expenses:

| Expense | Target cost |
|---|---:|
| Daily food allowance | 35 |
| Daily utilities | 25 |
| Daily miscellaneous living costs | 15 |
| Daily rent allocation | 100 |
| Total daily baseline | 175 |

Target baseline living expense: 175 Credits per game day.

These values are adjustable through economic configuration.

### 5.3 Financial safety

The player must not become permanently trapped by recurring expenses.

Required safeguards:
- Essential living costs must have a warning period.
- Optional subscriptions can be cancelled.
- Nonessential services can be suspended.
- The player can accept recovery contracts.
- Essential gameplay must remain available at low balances.
- The game must not create an unrecoverable financial state through normal gameplay.

## 6. INCOME SYSTEM

### 6.1 Income sources

The economy supports multiple income categories.

| Income source | Description |
|---|---|
| Manual tasks | Completing household activities |
| Gigs | Short jobs with immediate payment |
| Contracts | Multi-stage paid objectives |
| Businesses | Revenue generated by owned businesses |
| Investments | Returns from purchased financial assets |
| Events | Rewards from unexpected opportunities |
| Property | Rental income from eligible properties |
| Automation services | Revenue from configured service systems |

### 6.2 Manual task rewards

Initial reward targets:

| Task category | Reward |
|---|---:|
| Basic cleaning | 15–25 |
| Washing dishes | 10–20 |
| Laundry | 20–35 |
| Taking out rubbish | 10–15 |
| Shopping | 20–40 |
| Basic maintenance | 25–50 |
| Organizing | 15–30 |
| Special inconvenience task | 40–75 |

Rewards must account for:
- Time required.
- Difficulty.
- Travel distance.
- Required equipment.
- Risk.
- Task complexity.

The same repetitive task must not provide unlimited exploitable income.

### 6.3 Gig work

Gigs provide flexible early-game income.

Target reward ranges:

| Gig type | Reward |
|---|---:|
| Simple delivery | 60–100 |
| Remote data entry | 50–90 |
| Product testing | 75–125 |
| Errand service | 80–140 |
| Technical assistance | 100–175 |
| Specialist contract | 150–250 |

Gigs may introduce:
- Deadlines.
- Travel.
- Equipment requirements.
- Quality ratings.
- Optional bonuses.
- Repeat customer opportunities.

### 6.4 Contract income

Contracts are longer activities with defined objectives.

A contract contains:
- Contract ID.
- Issuing organization.
- Description.
- Requirements.
- Completion conditions.
- Time limit, if applicable.
- Base payment.
- Bonus payment.
- Failure conditions.
- Reputation impact.

Contract rewards must be calculated from difficulty, duration, and requirements.

## 7. EXPENSE SYSTEM

### 7.1 Expense categories

The player economy supports:

- Housing.
- Food.
- Utilities.
- Internet.
- Transportation.
- Maintenance.
- Consumables.
- Insurance.
- Subscriptions.
- Business operations.
- Property improvements.
- Optional entertainment.

### 7.2 Expense behavior

Expenses must be visible before payment.

The player must be able to inspect:
- Upcoming payment.
- Payment date.
- Amount.
- Reason.
- Whether the expense is optional.
- Consequences of cancellation or nonpayment.

### 7.3 Expense escalation

Higher-tier properties introduce higher operating costs.

The player should understand the ongoing expense before purchasing or upgrading a property.

An expensive property must provide corresponding benefits, opportunities, space, or status.

## 8. ITEM PRICING

### 8.1 Furniture

| Category | Target price range |
|---|---:|
| Basic furniture | 25–150 |
| Standard furniture | 150–500 |
| Premium furniture | 500–1,500 |
| Luxury furniture | 1,500–5,000 |
| Designer furniture | 5,000–15,000 |

Furniture is primarily a customization and property-value system, with selected objects providing functional benefits.

### 8.2 Appliances

| Category | Target price range |
|---|---:|
| Basic appliances | 100–400 |
| Improved appliances | 400–1,000 |
| Premium appliances | 1,000–3,000 |
| Luxury appliances | 3,000–8,000 |

Appliances may improve:
- Task completion speed.
- Resource consumption.
- Quality.
- Capacity.
- Reliability.
- Automation compatibility.

### 8.3 Gadgets

| Category | Target price range |
|---|---:|
| Basic gadgets | 50–250 |
| Useful gadgets | 250–750 |
| Advanced gadgets | 750–2,000 |
| Premium gadgets | 2,000–6,000 |

Gadgets should offer meaningful utility, convenience, information, or entertainment.

## 9. AUTOMATION ECONOMY

Automation is the defining economic progression system.

### 9.1 Automation categories

- Cleaning.
- Laundry.
- Food preparation.
- Shopping.
- Maintenance.
- Security.
- Property management.
- Scheduling.
- Business operations.
- Integrated household management.

### 9.2 Automation pricing

| Automation tier | Target price |
|---|---:|
| Basic automation | 500–1,500 |
| Improved automation | 1,500–4,000 |
| Advanced automation | 4,000–10,000 |
| Premium automation | 10,000–25,000 |
| Integrated automation | 25,000–60,000 |

### 9.3 Automation value

Every automation purchase must have measurable effects.

Possible effects:
- Removes a manual task.
- Reduces task frequency.
- Reduces task duration.
- Prevents inconvenience events.
- Improves household quality.
- Reduces operating costs.
- Improves business productivity.
- Creates additional available player time.

Automation must not simply be a more expensive cosmetic object.

### 9.4 Automation efficiency

Automation performance depends on:
- Device quality.
- Available power.
- Connectivity.
- Maintenance condition.
- Available supplies.
- Environmental conditions.
- Compatible equipment.
- Configuration quality.

Automation failures must be understandable and recoverable.

### 9.5 Automation operating expenses

Devices may require:
- Electricity.
- Consumables.
- Maintenance.
- Repairs.
- Replacement components.

Operating costs must be visible in the purchase interface.

The player must be able to compare the operating expense against the convenience gained.

## 10. ROBOT ECONOMY

Robots are more advanced autonomous systems.

Initial pricing targets:

| Robot type | Target price |
|---|---:|
| Basic cleaning robot | 1,500 |
| Utility robot | 3,000 |
| Household assistant | 6,000 |
| Advanced service robot | 12,000 |
| Premium autonomous assistant | 25,000 |

Robot capabilities may include:
- Cleaning.
- Carrying objects.
- Deliveries.
- Maintenance.
- Organization.
- Task scheduling.
- Multi-task coordination.

Robots require:
- Purchase cost.
- Maintenance condition.
- Charging or power.
- Task configuration.
- Optional upgrades.

Robots must be visibly active in the world. They are not merely inventory icons.

## 11. PROPERTY PROGRESSION

### 11.1 Property tiers

| Property tier | Target purchase value |
|---|---:|
| Starter apartment | Rental property |
| Improved apartment | 25,000–45,000 |
| Premium apartment | 60,000–100,000 |
| Penthouse | 150,000–300,000 |
| Large house | 350,000–650,000 |
| Mansion | 750,000–1,500,000 |

These are initial target values and require playtesting.

### 11.2 Property progression benefits

Properties may provide:
- More rooms.
- More placement capacity.
- More automation connections.
- More storage.
- Additional business opportunities.
- Higher comfort.
- Better event opportunities.
- Additional customization.
- Higher status.

### 11.3 Property operating costs

Every property must display:
- Purchase price.
- Financing, if applicable.
- Estimated utilities.
- Maintenance.
- Insurance.
- Taxes or other applicable costs.
- Available capacity.
- Available upgrade slots.

### 11.4 Property ownership

The property system must distinguish:
- Renting.
- Purchasing.
- Financing.
- Upgrading.
- Selling.
- Abandoning where appropriate.

Property sales must account for condition, upgrades, and market conditions.

## 12. BUSINESS ECONOMY

Businesses create a transition from personal convenience to wealth generation.

### 12.1 Initial business categories

| Business | Target establishment cost |
|---|---:|
| Vending operation | 5,000 |
| Automated laundry service | 12,000 |
| Delivery operation | 20,000 |
| Cleaning service | 30,000 |
| Automated retail shop | 45,000 |
| Property management service | 75,000 |

### 12.2 Business financial model

Each business tracks:
- Initial investment.
- Operating expenses.
- Revenue.
- Profit.
- Equipment condition.
- Staff or automation capacity.
- Customer demand.
- Reputation.
- Inventory.
- Maintenance.
- Operational interruptions.

Net operating profit:

Net Profit = Revenue - Operating Expenses

Cash flow:

Cash Flow = Income Received - Expenses Paid

Return on investment:

ROI = (Net Profit / Initial Investment) × 100

Payback period:

Payback Period = Initial Investment / Average Net Profit Per Period

All calculations must use consistent time periods.

### 12.3 Business upgrades

Business upgrades may improve:
- Production capacity.
- Customer volume.
- Service speed.
- Quality.
- Automation.
- Operating efficiency.
- Reliability.
- Profit margins.

Upgrades must have displayed costs and expected effects.

### 12.4 Business automation

Businesses should eventually operate with minimal direct player involvement.

The player remains responsible for strategic decisions, investments, expansion, and exceptional situations.

## 13. INVESTMENT SYSTEM

Investment opportunities become available after the player establishes financial stability.

Potential investments:
- Savings accounts.
- Bonds.
- Business shares.
- Property investments.
- Managed portfolios.
- Higher-risk speculative opportunities.

Investment systems must communicate:
- Initial capital.
- Expected return range.
- Time horizon.
- Risk level.
- Liquidity.
- Potential losses.

Returns must not be guaranteed unless the specific investment is explicitly designed as a guaranteed product.

Market events may affect investment performance.

## 14. PLAYER PROGRESSION

### 14.1 Progression dimensions

The player progresses through multiple independent dimensions:

- Net worth.
- Property ownership.
- Automation capability.
- Business ownership.
- Reputation.
- Technology access.
- Lifestyle quality.
- Collection completion.
- Achievements.

No single progression statistic should control the entire game.

### 14.2 Player levels

Player level is an optional broad progression indicator.

Experience may be awarded for:
- Completing tasks.
- Purchasing significant upgrades.
- Establishing businesses.
- Expanding properties.
- Completing contracts.
- Unlocking automation milestones.
- Completing major events.

Experience must not be awarded indefinitely for repetitive low-value actions.

### 14.3 Unlock requirements

Unlocks may depend on:
- Player level.
- Net worth.
- Property tier.
- Business reputation.
- Completed contracts.
- Previous purchases.
- Specific achievements.

Unlock requirements must be displayed clearly.

### 14.4 Progression milestones

| Milestone | Intended achievement |
|---|---|
| First convenience | Purchase the first meaningful appliance |
| First automation | Eliminate a repetitive household task |
| Automated home | Automate several household responsibilities |
| First robot | Introduce autonomous physical assistance |
| Financial stability | Cover regular expenses reliably |
| First business | Establish a revenue-producing operation |
| Business expansion | Operate multiple revenue streams |
| Premium lifestyle | Own a high-tier property |
| Convenience empire | Operate a largely autonomous lifestyle |

## 15. REPUTATION AND CUSTOMER DEMAND

Reputation affects business opportunities and selected events.

Reputation may be influenced by:
- Service quality.
- Contract completion.
- Reliability.
- Customer satisfaction.
- Business performance.
- Event outcomes.

Reputation must not be reduced arbitrarily.

Players must be able to inspect why reputation changed.

Demand may be affected by:
- Business location.
- Service quality.
- Market conditions.
- Competition.
- Reputation.
- Upgrades.
- Events.

## 16. EVENTS AND ECONOMIC DISRUPTIONS

Events create variation in the economy.

Examples:
- Appliance discounts.
- Unexpected repairs.
- Utility price increases.
- Business opportunities.
- Customer surges.
- Equipment failures.
- Special contracts.
- Property opportunities.
- Technology sales.
- Unusual neighborhood incidents.

Event rules:
- Events must have clear outcomes.
- Financial consequences must be visible.
- Major negative events must allow reasonable recovery.
- Events must not randomly destroy long-term progression.
- Some events must reward preparation and automation.

## 17. ECONOMIC BALANCING FORMULAS

### 17.1 Purchase affordability

Affordability Ratio:

Affordability Ratio = Current Balance / Purchase Price

A value below 1.0 means the player cannot purchase the item outright.

### 17.2 Operating efficiency

Operating Efficiency:

Operating Efficiency = Actual Output / Expected Output

Efficiency must be bounded by the applicable system limits.

### 17.3 Automation savings

Estimated Savings:

Automation Savings = Manual Operating Cost Avoided - Automation Operating Cost

Time savings must be tracked separately from direct currency savings.

### 17.4 Investment payback

Payback Period:

Payback Period = Purchase Cost / Average Net Benefit Per Period

If the net benefit is zero or negative, the system must not display a finite payback estimate.

### 17.5 Price scaling

Price scaling must be based on item tier, utility, capacity, and progression stage.

Prices must not increase simply because the player has more money.

### 17.6 Economic safeguards

All economic calculations must validate:
- Nonnegative purchase prices.
- Valid transaction amounts.
- Overflow conditions.
- Valid time periods.
- Valid ownership.
- Duplicate transaction prevention.
- Insufficient funds.
- Refund limits.

## 18. USER INTERFACE REQUIREMENTS

The economy UI must include:

### Wallet
- Current balance.
- Recent transactions.
- Income summary.
- Expense summary.

### Financial overview
- Total assets.
- Outstanding obligations.
- Estimated recurring expenses.
- Average income.
- Average net cash flow.
- Business profit.
- Investment performance.

### Purchase interface
- Purchase price.
- Current balance.
- Remaining balance after purchase.
- Operating costs.
- Benefits.
- Requirements.
- Installation requirements.
- Refund or resale rules.

### Automation comparison
- Current manual effort.
- Expected automated effort.
- Operating expense.
- Maintenance requirements.
- Estimated time saved.
- Estimated financial savings.

### Business overview
- Revenue.
- Operating expenses.
- Net profit.
- Customer demand.
- Reputation.
- Equipment status.
- Upgrade opportunities.

The interface must display actual simulation data. It must never use decorative placeholder values in production gameplay.

## 19. SAVE AND PERSISTENCE REQUIREMENTS

The economy must persist:
- Currency balance.
- Transaction history.
- Purchased items.
- Owned properties.
- Property upgrades.
- Business ownership.
- Business financial history.
- Investment positions.
- Recurring expenses.
- Outstanding payments.
- Automation operating costs.
- Robot ownership and condition.
- Progression milestones.
- Unlocks.
- Reputation.

Saving must not duplicate transactions or award income twice.

Loading must restore the economic state consistently.

Offline progression must use recorded timestamps and validated elapsed time. It must not allow unlimited or exploitable accumulation.

## 20. ANTI-EXPLOIT AND INTEGRITY REQUIREMENTS

The economy must prevent:
- Repeated reward claims.
- Duplicate purchases.
- Duplicate refunds.
- Negative purchase prices.
- Overflow exploits.
- Unlimited task farming.
- Repeated event rewards.
- Save/load reward duplication.
- Invalid business income.
- Time manipulation exploits.

All important transactions must be processed through the central economy service.

UI buttons must never independently modify currency balances.

## 21. INITIAL BALANCING TARGETS

The following are initial playtesting targets, not guaranteed final values.

| Gameplay milestone | Target playtime |
|---|---:|
| First useful purchase | 5–10 minutes |
| First automation purchase | 20–40 minutes |
| First automated household task | 30–60 minutes |
| First robot | 1–3 hours |
| Financial stability | 2–4 hours |
| First business | 3–5 hours |
| First major property upgrade | 5–8 hours |
| Premium lifestyle | 10–15 hours |
| Established convenience empire | 20+ hours |

Progression targets must be validated through actual player testing.

The game must not artificially extend playtime through repetitive waiting.

## 22. ECONOMIC TELEMETRY

Development builds should record:

- Average player balance.
- Average income per game day.
- Average expenses per game day.
- Time to first purchase.
- Time to first automation.
- Time to first robot.
- Time to first business.
- Purchase frequency.
- Item ownership frequency.
- Business profitability.
- Player bankruptcy or recovery frequency.
- Unused currency accumulation.
- Progression completion time.

Telemetry must respect player privacy and applicable platform requirements.

## 23. TESTING REQUIREMENTS

Required automated tests:

1. Starting balance is assigned correctly.
2. Purchases deduct the correct amount.
3. Insufficient funds reject a purchase.
4. Refunds cannot be duplicated.
5. Transaction history records correct balances.
6. Recurring expenses execute once per period.
7. Cancelled expenses do not execute.
8. Automation operating costs are calculated correctly.
9. Business revenue and expenses balance correctly.
10. Investment calculations handle losses.
11. Offline progression respects configured limits.
12. Save/load preserves the complete economic state.
13. Repeated task claims cannot duplicate rewards.
14. Large values do not overflow.
15. Invalid economic configuration is rejected.
16. Property sales calculate valid proceeds.
17. Business upgrades apply the correct effects.
18. Progression unlocks occur only when requirements are satisfied.

### 23.1 Balance testing

Playtesting must cover:
- Highly active players.
- Casual players.
- Players who prioritize automation.
- Players who prioritize property.
- Players who prioritize business.
- Players who make poor financial decisions.
- Players who avoid optional activities.

No single strategy should make every other strategy meaningless.

## 24. PRODUCTION CONFIGURATION

Economic values must be data-driven.

Required configurable data:
- Currency definitions.
- Task reward definitions.
- Gig reward definitions.
- Contract reward definitions.
- Item prices.
- Automation costs.
- Robot prices.
- Property values.
- Recurring expense definitions.
- Business costs.
- Business revenue models.
- Upgrade costs.
- Progression requirements.
- Investment parameters.
- Event financial effects.

Configuration changes must be validated before entering the active simulation.

Balance changes must not require rewriting unrelated gameplay systems.

## 25. DEFINITION OF DONE

The economy and progression system is production-ready when:

- All income sources are functional.
- All expense sources are functional.
- Purchases are validated and persistent.
- Transaction history is accurate.
- Automation has measurable economic and time benefits.
- Robots have operating and maintenance costs.
- Properties have functional ownership and expense systems.
- Businesses generate correctly calculated income.
- Investments handle both gains and losses.
- Progression unlocks are reliable.
- Economic exploits are tested.
- Save/load preserves all financial state.
- UI displays real economic values.
- Balance data can be adjusted without modifying core logic.
- Automated tests pass.
- Playtesting confirms that progression is rewarding and understandable.

---

## FINAL ECONOMIC DESIGN PRINCIPLE

The player begins by spending time to earn money.

They then spend money to save time.

Eventually, they build systems that earn money while saving time.

The ultimate reward is not simply becoming wealthy. It is creating a world in which nearly every inconvenience has been solved, delegated, automated, or purchased out of existence.

**The Game for Lazy People: Doing Nothing Has Never Been This Much Work.**
