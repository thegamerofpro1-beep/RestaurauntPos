# RestaurantPOS14 reconstruction renames

Only compiler-required identifier changes are recorded here. No type or public member has been renamed.

| Scope | Original/PDB name | Reconstructed name | Reason |
|---|---|---|---|
| `frmPOS.ProcessEInvoiceQueueAsync`, simulation update local | `up2` | `upSimulation` | The PDB assigned the same local name to overlapping C# scopes; C# and VB both reject the collision. |
| `frmPOS.ProcessEInvoiceQueueAsync`, cancellation update local | `up2` | `upCancel` | The PDB assigned the same local name to overlapping C# scopes; C# and VB both reject the collision. |
| `frmPOS.ProcessEInvoiceQueueAsync`, replacement update local | `up2` | `upReplace` | The PDB assigned the same local name to overlapping C# scopes; C# and VB both reject the collision. |
