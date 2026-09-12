# Cancel Unpaid Bill

Available to every signed-in Front Office user, regardless of role or the original bill operator.

1. Open Dine In Billing > Cancel Unpaid Bill (replaces Undo Bill).
2. Select the bill. The list includes all dates/operators and shows affected tables.
3. Enter a reason and confirm cancellation of the complete bill, including merged tables.
4. Return to Dine In and select the table/order again. Correct or delete the order, then create a new bill.

Only fully unpaid **Normal Bill** records are eligible. Recorded cash, change, card, gift-card/loyalty redemption, member/credit account entries, loyalty ledger entries, split bills and e-invoice queue records prevent cancellation. These cases require reconciliation, not a pretend cash payment.

Cancellation does not change kitchen orders, stock, payments or refunds. A serializable transaction archives the complete bill, items and ledger snapshot in `DineInBillCancellations`, records the operator/reason in existing `DeletedInvoices` history, removes the unpaid sales accrual and removes the active billing records. A failure rolls the complete transaction back. Historical bill numbers remain reserved by both dine-in bill generators.

Database schema migration 6 creates the archive automatically for existing databases and during new-database provisioning. Update all terminals sharing the database before using cancellation, so old bill-number generators and the old Undo Bill action are not used.

Validation: `build/phase3/UnpaidBillCancellationSmoke.vb` creates an isolated, uniquely named test database, exercises the legacy-schema upgrade and cancellation scenarios, and never cancels a production bill. It leaves the test database available for inspection unless explicitly removed later.
