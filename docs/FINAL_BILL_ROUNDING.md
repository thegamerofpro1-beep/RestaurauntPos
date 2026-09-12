# Final bill rounding

Version 14.1.5.10 applies nearest-10-sen rounding to the final payable total for new or recalculated dine-in, takeaway, home-delivery, express and item-split bills. All payment modes use the same rule.

Examples: RM1.64 becomes RM1.60; RM1.65 and RM1.67 become RM1.70; RM121.85 becomes RM121.90. Currency remains displayed with two decimal places.

`MoneyMath.RoundPayableTotal` uses decimal arithmetic and midpoint-away-from-zero rounding. `Billing.PayableTotal.Apply` sets the checkout amount and colored display from that result. The checkout amount is already the source for bill persistence, payment validation, change and ledger postings; Crystal receipt templates read the stored GrandTotal, without recalculating it at print time.

Rounding is applied after discounts, SST/service charges, parcel/delivery charges, tips, gift-card amounts and loyalty deductions. Do not use this helper for individual rows, taxes, tendered cash or change. Do not replace `RoundCurrency` with it: that would alter line amounts and taxes before the final total is known.

Existing saved receipts keep their original stored totals when reprinted. Opening an unpaid bill for recalculation/payment uses the new rule; this is not a historical database rewrite. An item-split bill is rounded independently as its own payable bill. No new database columns are required, and old databases remain readable.

Validation:

- `build/phase3/PayableRoundingSmoke.vb`: decimal boundaries/idempotence, invariant numeric text, all four checkout modes, percentage/amount discount branches, item-split checkout, change, delivery/tip order, unchanged line amounts and customer-display formatting. Uses synthetic in-memory rows; no sale writes or physical printing.
- `build/phase3/RoundingReceiptRenderSmoke.vb`: reads the configured database only to obtain legacy-compatible table schemas, replaces invoice data in memory with a synthetic RM1.67 bill, and exports all four receipt types with a RM1.70 final total. Uses no database writes.
- Physical receipt printers, payment terminals and pole-display hardware still require an on-site test after upgrading each till.
