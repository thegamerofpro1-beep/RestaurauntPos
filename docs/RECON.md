# RestaurantPOS14 Phase 0 recon

This is a read-only inventory of the requested executable, its matching symbol file, configuration, resources, and adjacent dependencies. No application source was emitted and no third-party DLL was decompiled.

Inspection used `ilspycmd`/ICSharpCode.Decompiler 9.1.0.7988 for managed-type confirmation and Mono.Cecil/Mono.Cecil.Pdb 0.11.6.0 for the exhaustive metadata, embedded-resource, and native-PDB sequence-point inventory.

## Gate result

Phase 0 is complete, but Phase 1 should not begin without a decision on the symbol provenance mismatch: the supplied PDB is a valid matching symbol file for this executable, yet every recorded source document is C#, under a prior `truedecompiled` tree. It cannot provide the original VB.NET source split claimed by the working prompt.

## Key findings and contradictions

- The executable is managed .NET, PE `I386`, `ILOnly`, and `Required32Bit`: it is definitively x86.
- The manifest targets `.NETFramework,Version=v4.8`, while `RestaurantPOS14.exe.config` declares `.NETFramework,Version=v4.0` and runtime version `v4.0`. The manifest target is authoritative for reconstruction; the config value is older.
- The matching PDB contains 807 documents, all 807 C# and 0 VB, with 307754 sequence points. Its embedded path is `C:\Users\User\Documents\truedecompiled\RestaurantPOS14\obj\x86\Release\RestaurantPOS14.pdb`.
- The current binary is therefore most consistent with a C# recompilation of a decompiled VB.NET application: VB runtime/My/Edit-and-Continue artifacts remain, but the supplied symbols describe the C# reconstruction rather than the earlier VB source.
- Metadata has 580 top-level types and 1296 types including nested/generated types. The prompt's `~390+` estimate corresponds closely to the 389 top-level types in the main namespace, not the complete metadata type count.
- Embedded resources total 280: 208 `.resources`, 71 Crystal `.rpt`, and 1 `.licenses`. The prompt's `~284 .rpt` expectation is contradicted by the assembly; there are exactly 71.
- There are 71 `Cachedrpt*` wrappers and 71 `ReportClass` types. All 71 report `ResourceName` values resolve one-to-one to embedded `.rpt` resources.
- `RestaurantPOS14.OnlineOrders` is absent. No metadata type name contains `OnlineOrder`, `DishInfo`, or `CategoryInfo`.
- `RestaurantPOS14.EInvoicing` exists with six top-level types, but the expected `DocumentSubmissionStatus` type is absent.
- `RECOVERY_SOURCE.exe` was not found beneath `L:\New Restauraunt Pos`. `FreshDecompile`/`Restored_Source` directories were not found.

## Target fingerprints

| File | Bytes | Last modified | SHA-256 |
|---|---:|---|---|
| RestaurantPOS14.exe | 45508096 | 2025-12-13 16:10:34 +08:00 | 5b9f7cc4d86e2377f7efbef396b86698417f650a8ddcd2850305c289d8539b71 |
| RestaurantPOS14.pdb | 15193600 | 2025-12-13 16:10:34 +08:00 | 49bda0e7830fcbb0f0af7d51ee7823d047122a35af1a0afe86955b262a462f5a |
| RestaurantPOS14.exe.config | 1256 | 2025-11-18 17:50:52 +08:00 | 4730a4035cbb03a49c30bd5f16bcd277ae0c8b13c839a6055df8e307f54e2493 |

## Assembly and entry point

| Property | Exact value |
|---|---|
| Assembly name | RestaurantPOS14 |
| AssemblyVersion | 14.1.5.0 |
| AssemblyFileVersion | 14.1.5.0 |
| Assembly title | Restaurant POS 14 |
| TargetFrameworkAttribute | .NETFramework,Version=v4.8 |
| CLR metadata runtime | v4.0.30319 |
| Module kind | Windows |
| PE architecture | I386 |
| CLR module attributes | ILOnly, Required32Bit |
| Interpreted platform | x86 |
| MVID | 34229e62-7a3a-4d2c-8a1c-500d3db7ae21 |
| GuidAttribute | 7aac41b1-f70d-4007-814d-b6f1ef9ab4d9 |
| ComVisibleAttribute | False |
| Entry point | System.Void RestaurantPOS14.My.MyApplication::Main(System.String[]) |
| STAThread on entry point | True |
| Entry point attributes | System.ComponentModel.EditorBrowsableAttribute, System.STAThreadAttribute, System.Diagnostics.DebuggerHiddenAttribute |
| CodeView GUID / age | eaf3ea16-4a40-4196-bc89-aeb97d338e45 / 1 |
| Embedded PDB path | C:\Users\User\Documents\truedecompiled\RestaurantPOS14\obj\x86\Release\RestaurantPOS14.pdb |

## Configuration observations

- Connection string name: `RestaurantPOS14.My.MySettings.RPOS_DBConnectionString`
- Provider: `System.Data.SqlClient`
- Data source: `DESKTOP-PUEKG2K`
- Initial catalog: `RPOS_DB`
- Integrated security: `True`
- Multiple active result sets: `True`
- `useLegacyV2RuntimeActivationPolicy`: `true`
- Supported runtime: `v4.0` / `.NETFramework,Version=v4.0`

Binding redirects:

| Assembly | Public key token | Old version | New version |
|---|---|---|---|
| CrystalDecisions.Shared | 692fbea5521e1304 | 0.0.0.0-13.0.3500.0 | 13.0.3500.0 |
| CrystalDecisions.ReportSource | 692fbea5521e1304 | 0.0.0.0-13.0.3500.0 | 13.0.3500.0 |

## Language/provenance evidence

| Evidence | Count/value | Interpretation |
|---|---:|---|
| PDB C# documents | 807 | Current compilation source language |
| PDB VB documents | 0 | No original VB documents are represented |
| `Microsoft.VisualBasic` assembly reference | present | Evidence of VB ancestry/runtime dependence |
| `Microsoft.CSharp` assembly reference | present | Consistent with reconstructed C# dynamic/late binding |
| `[DesignerGenerated]` types | 235 | VB designer artifacts retained |
| `[AccessedThroughProperty]` fields/properties | 0 | These attributes were not retained in the current recompilation |
| `__ENCList` fields | 724 | VB Edit-and-Continue scaffolding retained |
| Compiler-generated/name-pattern types | 34 | Includes anonymous/closure/state-machine artifacts |

## Namespace inventory

Nested types inherit their declaring type namespace for this table.

| Namespace | Top-level types | All types including nested | Generated/name-pattern types |
|---|---:|---:|---:|
| (global) | 4 | 4 | 4 |
| Microsoft.CodeAnalysis | 1 | 1 | 1 |
| RestaurantPOS14 | 389 | 1084 | 8 |
| RestaurantPOS14.EInvoicing | 6 | 21 | 15 |
| RestaurantPOS14.My | 6 | 10 | 4 |
| RestaurantPOS14.My.Resources | 1 | 1 | 1 |
| RestaurantPOS14.RPOS_DBDataSet1TableAdapters | 105 | 107 | 0 |
| RestaurantPOS14.RPOS_DBDataSetTableAdapters | 67 | 67 | 0 |
| System.Runtime.CompilerServices | 1 | 1 | 1 |

## Aggregate type/member counts

| Metric | Count |
|---|---:|
| Top-level types | 580 |
| All types including nested | 1296 |
| Declared fields | 12017 |
| Declared methods | 38031 |
| Declared properties | 12654 |
| Declared events | 684 |
| Direct `System.Windows.Forms.Form` subclasses | 237 |

## PDB source document summary

- Symbol source root: `C:\Users\User\Documents\truedecompiled\RestaurantPOS14\`
- Documents: 807
- Sequence points: 307754
- Languages: C# 807; VB 0
- These are matching line mappings for the current executable, but they are not evidence of the original VB file split.

| # | Document relative to symbol root | Language | Source hash algorithm | Source hash | Sequence points | Methods | Types | Visible line span |
|---:|---|---|---|---|---:|---:|---:|---|
| 1 | CachedrptBalanceReceipt.cs | CSharp | SHA256 | 82f1e7efee4631635d7c2e8bb9ebb6fe72a91675052d2b9e6b29f4619ca9b85f | 36 | 13 | 1 | 26-139 |
| 2 | CachedrptBalanceSheet.cs | CSharp | SHA256 | e716ce0089db03c8ba353cfca2a4eaa703a00274437f5d80128baaae4f33cbf0 | 36 | 13 | 1 | 26-139 |
| 3 | CachedrptBankAccountStatements.cs | CSharp | SHA256 | effb020a00bd33b5fdbd23fd0a263374483dbd10a03995fc962c8564c2557624 | 36 | 13 | 1 | 26-139 |
| 4 | CachedrptBankAccountStatements1.cs | CSharp | SHA256 | a271272e94192c1ed84b112247aa544c16f74508c6037dbaf729cb6411889d58 | 36 | 13 | 1 | 26-139 |
| 5 | CachedrptBarcodeLabelPrinting.cs | CSharp | SHA256 | a0e8a1677a606bcc1e50c805b42ad5a23d0e73cae6287078685481ca2442856c | 36 | 13 | 1 | 26-139 |
| 6 | CachedrptCollectionsByDP.cs | CSharp | SHA256 | ace294b6b0e467ffd3847d187f4f75276148ec749f4637b79414691c6d376083 | 36 | 13 | 1 | 26-139 |
| 7 | CachedrptCollectionsByDP1.cs | CSharp | SHA256 | 499178124fee653195dc85fbb741f86b5f3ec52b33551c4d8c53afc07ca44b58 | 36 | 13 | 1 | 26-139 |
| 8 | CachedrptCollectionsByWaiter.cs | CSharp | SHA256 | d37f5a273569a7d90cc751db30949d1d0c0aa5b98ad149a17e04e57fc65b793c | 36 | 13 | 1 | 26-139 |
| 9 | CachedrptCreditCustomerBalance.cs | CSharp | SHA256 | 86e565ebe28f51fcde30da4fd484b13374e0b7e7363a5f44d7380690ddcf76c5 | 36 | 13 | 1 | 26-139 |
| 10 | CachedrptCreditCustomerLedger.cs | CSharp | SHA256 | 0317bcd38cea67d1e8df23b608c2595259103af3c72f8e068600428c26dc91c7 | 36 | 13 | 1 | 26-139 |
| 11 | CachedrptCreditCustomerLedger1.cs | CSharp | SHA256 | 88dd363dfaeca8a8e15292d1af307c8d7401a30ae363ce30c22da9eb0ef090fd | 36 | 13 | 1 | 26-139 |
| 12 | CachedrptCreditors.cs | CSharp | SHA256 | 1dba89900c324bd39d3a5677248824fbf0f0237d6a2e38634ec1c243ce0e2fb1 | 36 | 13 | 1 | 26-139 |
| 13 | CachedrptDeletedBills.cs | CSharp | SHA256 | 03705cc7ec6e8f76b37068bc1aafe467f86142f8fd8eb4a2dce8870791644bd7 | 36 | 13 | 1 | 26-139 |
| 14 | CachedrptDeletedItems.cs | CSharp | SHA256 | dd128ebafa4da11ec49e06575dd5bd9441ec8d22510e78b84ed0743872b5ec93 | 36 | 13 | 1 | 26-139 |
| 15 | CachedrptExpenses.cs | CSharp | SHA256 | 7297e64a306bcbf68a7af19d7d121e631ac0fb4c77ed24abb80a1a50397ecde6 | 36 | 13 | 1 | 26-139 |
| 16 | CachedrptFundDepositReceipt.cs | CSharp | SHA256 | 54923d0fde43868c3ef0294994524423d06a6531e9c4c91ca7fbbe65a2d9b21d | 36 | 13 | 1 | 26-139 |
| 17 | CachedrptGeneralDayBook.cs | CSharp | SHA256 | e3d2d13ecb242f7361945814af805b62d3d261f4c12eccbd5009e43d4f5b541c | 36 | 13 | 1 | 26-139 |
| 18 | CachedrptGeneralLedger.cs | CSharp | SHA256 | c082be12cf6731b9908e4bf7af54a9b82e4405f71ffa9c2d9e9f32de78a21f57 | 36 | 13 | 1 | 26-139 |
| 19 | CachedrptGiftCard.cs | CSharp | SHA256 | cabb560e62607310c36ca132b5a2baeca6963220e0364a465f276b9d02b683d2 | 36 | 13 | 1 | 26-139 |
| 20 | CachedrptInputTax.cs | CSharp | SHA256 | 629bfd9904eacd7e055da35aadaeb90e68344640636f4c7825b5870604c05795 | 36 | 13 | 1 | 26-139 |
| 21 | CachedrptInvoiceSummary_CC.cs | CSharp | SHA256 | f51823578b51c650e32774aa3d5a527cf4d3826ae787f0ec6c126044c04f52a0 | 36 | 13 | 1 | 26-139 |
| 22 | CachedrptLoyaltyCard.cs | CSharp | SHA256 | 9b623e8dfb67d699d3c8c076d2030e0ffab3e1955b0a7263798bc2182a649ac2 | 36 | 13 | 1 | 26-139 |
| 23 | CachedrptLoyaltyCardMemberBalance.cs | CSharp | SHA256 | 650e2c10c0a996c629715fdae52871007bd0d2f0a8a034b2dd820d5ff362a774 | 36 | 13 | 1 | 26-139 |
| 24 | CachedrptLoyaltyCardMemberLedger.cs | CSharp | SHA256 | deb71352575e9ae28fd367fd2335cdc93605a82a2eb9002948d0d463448dd796 | 36 | 13 | 1 | 26-139 |
| 25 | CachedrptLoyaltyCardMemberLedger1.cs | CSharp | SHA256 | ba35631c554408156a8e9595a8ed3e898d29484da9bdcc5087f79e80a8dd25e7 | 36 | 13 | 1 | 26-139 |
| 26 | CachedrptMemberBalance.cs | CSharp | SHA256 | 9ae0934ae55b8bcfb0635a1b4b5b41296e4b4dc6350e96232545792154a268a3 | 36 | 13 | 1 | 26-139 |
| 27 | CachedrptMemberLedger.cs | CSharp | SHA256 | 9bd765ebf4d74657975e1fdf58f2a75ad7851988c473ab38a9dc4b493ff65a6c | 36 | 13 | 1 | 26-139 |
| 28 | CachedrptMemberLedger1.cs | CSharp | SHA256 | d34cfadef138776d0ba773e427d46265ab860ed04d04f04e864922f136b8860b | 36 | 13 | 1 | 26-139 |
| 29 | CachedrptMenuItems.cs | CSharp | SHA256 | d1ee7590f91239441c9a34baddc5fd25516cf26ad9cb424b8781249b056d8e0c | 36 | 13 | 1 | 26-139 |
| 30 | CachedrptPayment_WithdrawalReceipt.cs | CSharp | SHA256 | 313285d50e1b0cd3a5cdd126a4785911936eb2d49d58eea3102fce0e40862510 | 36 | 13 | 1 | 26-139 |
| 31 | CachedrptPaymentInvoice.cs | CSharp | SHA256 | 8777c85958ddbb39e812f7fe351abce06be4cebfe97f67a136af919dad16c122 | 36 | 13 | 1 | 26-139 |
| 32 | CachedrptPOS80mmByOperator.cs | CSharp | SHA256 | 6989fefd44a07f5d860d432077a4646affcc4030411859dbe501cd54a174f6c8 | 36 | 13 | 1 | 26-139 |
| 33 | CachedrptPOSA4.cs | CSharp | SHA256 | 693eff763d9f9bf06a7c8f2289a789380901f561088a1515709eff2a842f9fe8 | 36 | 13 | 1 | 26-139 |
| 34 | CachedrptPOSA4ByOperator.cs | CSharp | SHA256 | 25688a9965e68e39dc3b4b207a25b5b1a0322893f8a0fc746f6f6d588c1b34c2 | 36 | 13 | 1 | 26-139 |
| 35 | CachedrptPOSA4X.cs | CSharp | SHA256 | 312c84e7fff60056cf98f8361d3a125fc6ff076a16617f2f69f7af6c5cf06bd3 | 36 | 13 | 1 | 26-139 |
| 36 | CachedrptPurchase.cs | CSharp | SHA256 | 6cf9049e20948ed4fada2f7af1c42bd60bb966c5b3a036f18b2dcfac49b9950d | 36 | 13 | 1 | 26-139 |
| 37 | CachedrptPurchaseDayBook.cs | CSharp | SHA256 | d35e42412ed8e49f34c9c5cc678e0b47ee059e17956617d28b32a722d479d0cc | 36 | 13 | 1 | 26-139 |
| 38 | CachedrptPurchaseOrder.cs | CSharp | SHA256 | b464470152a260c8148fc38598bfc8556608d3c0d4fc9a4da21e52ecc3f56d0c | 36 | 13 | 1 | 26-139 |
| 39 | CachedrptReceipt.cs | CSharp | SHA256 | c9081e5855aa38cd79c220c7e1c97a6a4127ce9b69d5e59afe12688daea34584 | 36 | 13 | 1 | 26-139 |
| 40 | CachedrptReceiptTP.cs | CSharp | SHA256 | 4fdcd9787f8ae5214e68a18319b888f12e6ecec0517d59db892e416d694107a4 | 36 | 13 | 1 | 26-139 |
| 41 | CachedrptRecipe.cs | CSharp | SHA256 | d18108a2bcc4e23ce4c18c6e278d725908488db86706ea9aaf5236a092d4ec48 | 36 | 13 | 1 | 26-139 |
| 42 | CachedrptRestaurantPOS.cs | CSharp | SHA256 | dcca4a00c92ce082627dd9358c6a52fcb2b75ac3a3678477c701e4ded54f60c1 | 36 | 13 | 1 | 26-139 |
| 43 | CachedrptRestaurantPOSEB.cs | CSharp | SHA256 | 33fa81700712a7a8278f455e8bef092170c61a2896e0ba8bab17e761ee9d7ba7 | 36 | 13 | 1 | 26-139 |
| 44 | CachedrptRestaurantPOSEBInvoice_Kitchen.cs | CSharp | SHA256 | 9c2eccdf7d7740e8c1bccac6355a8c8cbf14bff8e76b076ffbfc2cd2b03aef72 | 36 | 13 | 1 | 26-139 |
| 45 | CachedrptRestaurantPOSEBInvoice.cs | CSharp | SHA256 | 092608ec0076628ab4318b8024314c8f86d95bdf60a40fc3e81e5fbff9396725 | 36 | 13 | 1 | 26-139 |
| 46 | CachedrptRestaurantPOSFinalBillKOTInvoice.cs | CSharp | SHA256 | 75fdf052d2ff228a0ca77e6ca6178c750b3c0a6d5d26b8bfffb18e1b3a96f717 | 36 | 13 | 1 | 26-139 |
| 47 | CachedrptRestaurantPOSHD.cs | CSharp | SHA256 | ebff165c65c7cbd6bae7111ab2d38ad17df9717087eeeffafdfafdbcf73a8c2d | 36 | 13 | 1 | 26-139 |
| 48 | CachedrptRestaurantPOSHDInvoice_Kitchen.cs | CSharp | SHA256 | 7b7a7be497d31b6ad11f7cca5d4bb13e44b06d673f8afcedba02805af005db6a | 36 | 13 | 1 | 26-139 |
| 49 | CachedrptRestaurantPOSHDInvoice.cs | CSharp | SHA256 | f7e1733d9cf1b7feace62eae6f2e6a1293bd004d27bc24609abf0c50b0896fc6 | 36 | 13 | 1 | 26-139 |
| 50 | CachedrptRestaurantPOSKOTInvoice_Kitchen.cs | CSharp | SHA256 | ec735d7b5ef4b4d78d10fafe4f2519dd972d467d16dbf21bd0b3b359ba4b6dee | 36 | 13 | 1 | 26-139 |
| 51 | CachedrptRestaurantPOSTA.cs | CSharp | SHA256 | d1bd5a9e3e95f99453b5314e79b5ab27aba1c3fd4d549a80275a707bc33c6d60 | 36 | 13 | 1 | 26-139 |
| 52 | CachedrptRestaurantPOSTAInvoice_Kitchen.cs | CSharp | SHA256 | 783947c4e15b3c223fdd65635da2986707e21111210375f81f8496c3b1c1c3e8 | 36 | 13 | 1 | 26-139 |
| 53 | CachedrptRestaurantPOSTAInvoice.cs | CSharp | SHA256 | fc91ead3cd635a079b6545504ccf9dbdb96c76bfc93d2931f58382ca1c2094e0 | 36 | 13 | 1 | 26-139 |
| 54 | CachedrptRestaurantPOSUpdatedKOTInvoice_Kitchen.cs | CSharp | SHA256 | 864b396227b7bc3f5120e80d135d28ae53d98885e0aa72dd6b97b243c96b669f | 36 | 13 | 1 | 26-139 |
| 55 | CachedrptRestaurantPOSVoidKOT_Kitchen.cs | CSharp | SHA256 | 7c7e41250df493ea6a931d98bea248d0b2bee058ba92be91c4d1d43cfeddca92 | 36 | 13 | 1 | 26-139 |
| 56 | CachedrptRPOS.cs | CSharp | SHA256 | 5b242a37abb23741303e9a7a9a855de07b3c1270b68da7b09b3eacaf4f3d4c21 | 36 | 13 | 1 | 26-139 |
| 57 | CachedrptRPOS1.cs | CSharp | SHA256 | bcc3624649d230943e62e1a57ab4e46a3918b69da6b61be921f306d2dbb97b81 | 36 | 13 | 1 | 26-139 |
| 58 | CachedrptRPOS2.cs | CSharp | SHA256 | eff3f29a9c9f4c200c4ef0849044fc981621d65ab2feb4de489c7f139f429e20 | 36 | 13 | 1 | 26-139 |
| 59 | CachedrptRPOSByKitchen.cs | CSharp | SHA256 | 9f2035ae2b9a90e804a69613aa47361f02e9d54b059d3b50215ca00426ef0564 | 36 | 13 | 1 | 26-139 |
| 60 | CachedrptRPOSByMonth.cs | CSharp | SHA256 | 0717a90e7e897fcf3ff605641b18a413d8b9f02f189f8ac5990310501b1cbef0 | 36 | 13 | 1 | 26-139 |
| 61 | CachedrptRPOSCard.cs | CSharp | SHA256 | fdf1413e4cc8bc898cc4df9ede742f7c6c6eeb0f75bd1e264c646bbce8d0f215 | 36 | 13 | 1 | 26-139 |
| 62 | CachedrptSalarySlip_MB.cs | CSharp | SHA256 | 57f26b10ea8af4dbcf7edce16c493f8d731c804a288a0f1523f6ce62875a4b5d | 36 | 13 | 1 | 26-139 |
| 63 | CachedrptSalarySlip.cs | CSharp | SHA256 | 831c6749d3a3b457f84f36009101de843dc468141016c7b3555ba3c816f3798f | 36 | 13 | 1 | 26-139 |
| 64 | CachedrptStockTransfer.cs | CSharp | SHA256 | a289676bdd23928848318e3c3905374ff9f2f18205b691eb5f44f631523b2807 | 36 | 13 | 1 | 26-139 |
| 65 | CachedrptStockTransferInvoice.cs | CSharp | SHA256 | 8b77ce270f6fcb678d1c4c37c451a31ca195e7331653ac0b25bc9925a014ce3a | 36 | 13 | 1 | 26-139 |
| 66 | CachedrptSupplierLedger.cs | CSharp | SHA256 | 1a1d86e4e20ac2bb148cb8cd52b7d0d37ecfb4d28c6f4a915f45ba9a3b7e7abf | 36 | 13 | 1 | 26-139 |
| 67 | CachedrptTax.cs | CSharp | SHA256 | 423c4730005b6cf4fc66e65c83e4fa20d70ccbe581006a69d29babd6e63cf139 | 36 | 13 | 1 | 26-139 |
| 68 | CachedrptTrialBalance.cs | CSharp | SHA256 | f101104461e8a437584c585a9b0b155b284251e3fa27a137caeaa658bbd7b11d | 36 | 13 | 1 | 26-139 |
| 69 | CachedrptVoidKOT.cs | CSharp | SHA256 | 0a3f3c52fd17e0072acae3173de315e5d54f812835f6a5a8abf5f3816e248962 | 36 | 13 | 1 | 26-139 |
| 70 | CachedrptVoucher.cs | CSharp | SHA256 | adea2d5650051fb5e6e31fc146da5263604f5523fc62f5c38b1ab07d03e6c27e | 36 | 13 | 1 | 26-139 |
| 71 | CachedrptWPByKitchen.cs | CSharp | SHA256 | d3e3359658e462e87015e06b36d51393d361f4df6fb708a7ad3b02dff965b4d1 | 36 | 13 | 1 | 26-139 |
| 72 | ConnectionString.cs | CSharp | SHA256 | eb5a319c6e68a77d6a498d5606de4fb46f1aea78cab9e8edfe82958189c83e8f | 7 | 2 | 1 | 15-26 |
| 73 | EInvoiceIntegration\EInvoiceClient.cs | CSharp | SHA256 | 3bbb880968190e2b05b4ba2aec1982b380727c516d2faf3d05f57d3944dfb9fc | 205 | 27 | 9 | 13-246 |
| 74 | EInvoiceIntegration\EInvoiceConfig.cs | CSharp | SHA256 | 4cd1b9bfcef0fff6d58e6e3604bd70b47967a36ce13d45b8bc88e955880c5bdd | 9 | 9 | 1 | 13-24 |
| 75 | EInvoiceIntegration\EInvoiceQueue.cs | CSharp | SHA256 | 31f13c104635ab0bec027a15b0b828122d40e7fe543c6f329c3a9d199396f01f | 125 | 25 | 6 | 10-100 |
| 76 | Encryption.cs | CSharp | SHA256 | 77e450a6c7c5df61f14ea2d8fb725681fd9d34626d86422706644700f3777b8d | 73 | 7 | 1 | 12-168 |
| 77 | frmAbout.cs | CSharp | SHA256 | 95ce1614c0e8285c2c347395005889a4b6f29c0b5f711ccf1e0a024ca38422a0 | 67 | 21 | 1 | 26-240 |
| 78 | frmAbout.Designer.cs | CSharp | SHA256 | 88ec481dfc1e34ddc299d6d110ca0e72dbe8350f400f23fe6e2faec68605b5a3 | 187 | 2 | 1 | 13-208 |
| 79 | frmAccountingReport.cs | CSharp | SHA256 | 1dcafcf7e92f3a24e998aa561a70f6ebe13226287f470517085e9efea8493791 | 979 | 138 | 1 | 31-2177 |
| 80 | frmAccountingReport.Designer.cs | CSharp | SHA256 | c552e46e619d51b9855b742f2388863385fff054d377711f64936cbb3a8982a0 | 1222 | 2 | 1 | 13-1483 |
| 81 | frmAddFunds.cs | CSharp | SHA256 | 90dd6e432aba7e0d208465ce5ff65e0d224513951465c3bf6345dde8fb24dad9 | 355 | 80 | 1 | 28-1043 |
| 82 | frmAddFunds.Designer.cs | CSharp | SHA256 | 06295acc46442b20a3770a5fd8143e752bd442b53f54d618e1c571c48761f41d | 475 | 2 | 1 | 13-501 |
| 83 | frmAddFundsRecord.cs | CSharp | SHA256 | c895c8250338c5ef87e536a2c403db41c8e0874d3abcb3b5719211d13f18be00 | 213 | 59 | 1 | 28-716 |
| 84 | frmAddFundsRecord.Designer.cs | CSharp | SHA256 | 529b6b8b0d4aec487b57a0c41ad98ced887d67c9e2b7e0c90719776c9a7370d6 | 365 | 2 | 1 | 13-393 |
| 85 | frmAdvancedSettings.cs | CSharp | SHA256 | 23b9bcebff8674991876154ea98a11e0d264b6a420d6103b365ec026d38df010 | 130 | 8 | 1 | 24-187 |
| 86 | frmAssignedTablesList_Waiter.cs | CSharp | SHA256 | cc8322849ab974f168f926bd81fbe4ea98e19fdd91a586ebe3406efac74550e0 | 124 | 15 | 1 | 29-278 |
| 87 | frmAssignedTablesList_Waiter.Designer.cs | CSharp | SHA256 | 3bdf1bb622de7487c9c224b04346f43c30b611d96a2e5040603609c90f57e0c0 | 71 | 2 | 1 | 13-92 |
| 88 | frmAttendance.cs | CSharp | SHA256 | 2ece6518311e0e8ab6b5442b69f9d9581b63e6f010023c3fd10a5fa8749e1fcf | 269 | 35 | 1 | 29-616 |
| 89 | frmAttendance.Designer.cs | CSharp | SHA256 | 657ff6536cd78d74e142c4b275c5ec3cc86e1ff00e4fb94035487c8b486aa464 | 162 | 2 | 1 | 13-203 |
| 90 | frmAvailableTables.cs | CSharp | SHA256 | 5fa73ed529c25e87de7f844bf64958d40f9a78cf0d28f61371162c4d4fbda7e2 | 186 | 18 | 1 | 29-366 |
| 91 | frmAvailableTables.Designer.cs | CSharp | SHA256 | 0f8aff7833febc2947e2e0563e6cd995b1023dd6ce8a58f101ab8efb713526eb | 105 | 2 | 1 | 13-126 |
| 92 | frmBackOffice.cs | CSharp | SHA256 | 654c773e5b031d09405481a66c2f0917dc9600f667469f719b7f9cc9563fb9f6 | 631 | 163 | 1 | 31-1928 |
| 93 | frmBackOffice.Designer.cs | CSharp | SHA256 | 2bceaf480b325f37f9db23628ba55394a44a13ac8f4c6b53b52ac87ca00cf058 | 1826 | 2 | 1 | 13-2287 |
| 94 | frmBank.cs | CSharp | SHA256 | 164765160e081bd56537afb5bc41b7555d2c4f01a84f6ccacd87e0a98452d33e | 262 | 45 | 1 | 29-675 |
| 95 | frmBank.Designer.cs | CSharp | SHA256 | 1593b0b8ccb4cf267cb3356ac1abc7287f126af14aa890d27d588486c759b930 | 295 | 2 | 1 | 13-319 |
| 96 | frmBankAccountRegistration.cs | CSharp | SHA256 | 049b112719533d0356cf01888cdf0e4c139bac2a47db937bf2ac96afe6240462 | 619 | 143 | 1 | 29-1865 |
| 97 | frmBankAccountRegistration.Designer.cs | CSharp | SHA256 | e61d38a489cb0df61ab425752f76784d29aecaad8f7dc8aa2e7e21ba19c8d001 | 741 | 2 | 1 | 13-796 |
| 98 | frmBankAccountStatements.cs | CSharp | SHA256 | ba7bcba627641f4cd0a374deabafb4135b6a28c9301a096e4b773467621ce2d1 | 239 | 55 | 1 | 30-687 |
| 99 | frmBankAccountStatements.Designer.cs | CSharp | SHA256 | 9ca003e378d16844f578ac018abb1b2cdcb4eceed356b177b80dcc9044c6c056 | 311 | 2 | 1 | 13-332 |
| 100 | frmBankReconciliation.cs | CSharp | SHA256 | 49bc3a17bfc4c989d82d1599ebd92e3e91eb6b6a15b5048f871d029465f922da | 127 | 30 | 1 | 25-371 |
| 101 | frmBankReconciliation.Designer.cs | CSharp | SHA256 | 24bbbff334a8d69d2d012c83bc96438a12b6318b62f2f144458468c845842632 | 209 | 2 | 1 | 13-230 |
| 102 | frmBarcodeLabelPrinting.cs | CSharp | SHA256 | 1bbaead1444b91300b62c5a5088420cdfbeb8ac8e7a6bb9fa06f24caf05fcce1 | 295 | 60 | 1 | 28-821 |
| 103 | frmBarcodeLabelPrinting.Designer.cs | CSharp | SHA256 | f0222eeec38712ae4a3a01adc54c52662dd6fa17da777c6c6d71c7468bf4dfd0 | 267 | 2 | 1 | 13-296 |
| 104 | frmBillSplit.cs | CSharp | SHA256 | c22546fac623c984461a39b56418474ce8413920e87005533b495f35a14b65de | 1552 | 262 | 1 | 31-3963 |
| 105 | frmBillSplit.Designer.cs | CSharp | SHA256 | cae3c371340182fbeaebe1ae60ae08a2f88783f7ea66b0dc41c43168fce75318 | 1465 | 2 | 1 | 13-1530 |
| 106 | frmBranchMaster_Bank.cs | CSharp | SHA256 | 6d42e61fd70c67ee038f92cc629daca267f6b75ec0f7ac582325b20dc0e92b1b | 406 | 83 | 1 | 30-1118 |
| 107 | frmBranchMaster_Bank.Designer.cs | CSharp | SHA256 | 6f1b6f7193666dabc31b1a0ebd5e3e9ee7a8679c309c653a2ec2d84fafdefa04 | 450 | 2 | 1 | 13-480 |
| 108 | frmCallerID.cs | CSharp | SHA256 | 680f20a54f9d7e19d959ea3c121af660b42a4428b7db7efb574ecfcc5283290e | 101 | 26 | 1 | 25-310 |
| 109 | frmCallerID.Designer.cs | CSharp | SHA256 | 91cc45adad1f930218bc82852f8db27da8c47ed814b6d0f6f239163cd6f444f9 | 112 | 2 | 1 | 13-133 |
| 110 | frmCards_POS.cs | CSharp | SHA256 | 4adfc350364cd17f897823d0d2c400b5e06ffea552596c6852ea6ea4db638695 | 178 | 23 | 1 | 30-419 |
| 111 | frmCards_POS.Designer.cs | CSharp | SHA256 | 6f7389b712cc51b223ecafbe682f78ccdf043f1031a52043fbc64281d18c9ef2 | 188 | 2 | 1 | 13-249 |
| 112 | frmCards.cs | CSharp | SHA256 | 3f899f010eef4862f1a3bb66a2f14266ce8e215707e5c85dd2c9b89e76690ff3 | 86 | 17 | 1 | 26-241 |
| 113 | frmCards.Designer.cs | CSharp | SHA256 | eb63500f29e94ddd5992369d100718ef3152b27c31b86242138c25a4bbabd090 | 145 | 2 | 1 | 13-196 |
| 114 | frmCategoriesExportImport.cs | CSharp | SHA256 | 0a6094c0ee47e3952bda192661a42c2eb6463656fc53c2b49f420d136cb9ca28 | 236 | 42 | 1 | 31-601 |
| 115 | frmCategoriesExportImport.Designer.cs | CSharp | SHA256 | e886dff188748d0c3da94b08b7cf649a76b059cd2694fef371e3b13fa9c7630f | 291 | 2 | 1 | 13-317 |
| 116 | frmChangeQty.cs | CSharp | SHA256 | 52276d1fdb4131247d027010610fb655084beaba31dd1b0705529ccba903f8f1 | 548 | 67 | 1 | 27-1282 |
| 117 | frmChangeQty.Designer.cs | CSharp | SHA256 | befb0d1ad9bda6eff14472f39ffcd80de5b45ba2a9eb6d7c8f8aedd069e371f9 | 546 | 2 | 1 | 13-717 |
| 118 | frmChangeRate.cs | CSharp | SHA256 | b55eba57e0aeb3c27825951fd44a80b04777bef30d38b000d62c70f21d1c314f | 543 | 67 | 1 | 27-1277 |
| 119 | frmChangeRate.Designer.cs | CSharp | SHA256 | bdf2319b27a81569847fc94bc962f2b94345f3cfaf7e35cd22df823050eb869a | 546 | 2 | 1 | 13-717 |
| 120 | frmClockINandOUT.cs | CSharp | SHA256 | a75295c62443333da8e8a230cd7bb276ba85d628b36b7f8cafbcb67a04841127 | 159 | 25 | 1 | 29-403 |
| 121 | frmClockINandOUT.Designer.cs | CSharp | SHA256 | b0bba595dc1e8d42d4d298546c1de83a48fcaea2d23c714e67555e6b56ccc38d | 129 | 2 | 1 | 13-170 |
| 122 | frmCMISetting.cs | CSharp | SHA256 | 816ab74eee7dbea06d80ade6d2cb48ade373fe4505bf06c71be64a5e2421307c | 195 | 37 | 1 | 28-528 |
| 123 | frmCMISetting.Designer.cs | CSharp | SHA256 | 00caba57b777c81aaafa271f9db8d0f2928a6a75461b18f201076953bdbcdcf5 | 234 | 2 | 1 | 13-255 |
| 124 | frmCreditCustomer.cs | CSharp | SHA256 | 2221dcb113e9d0b40097d296cf0006af5d8a1040dae3055acb5525b139c08c3c | 76 | 17 | 1 | 27-224 |
| 125 | frmCreditCustomer.Designer.cs | CSharp | SHA256 | ab3c721e6eb9d35cf2fb2dfab08fb296406c85817bf20c902d7b208bb1153c87 | 158 | 2 | 1 | 13-209 |
| 126 | frmCreditCustomerBalance.cs | CSharp | SHA256 | 4bbe91ef004264df4223d7ca600f75afc9a1643d835e0307b7986ca38f410377 | 282 | 47 | 1 | 28-702 |
| 127 | frmCreditCustomerBalance.Designer.cs | CSharp | SHA256 | ad3354353147f71890da45d292260a4316d0f60f32b8a3bdae0ef75364ffe267 | 293 | 2 | 1 | 13-325 |
| 128 | frmCreditCustomerLedger.cs | CSharp | SHA256 | cde93bf13a678cb792fee2bed448684c14402a203add69c0fa811c2f4ed4c535 | 300 | 71 | 1 | 30-881 |
| 129 | frmCreditCustomerLedger.Designer.cs | CSharp | SHA256 | ed2c7713aa79fcc91f56cebfa3e03ed8be69c82d123b3b78f1bc6f9466423d35 | 386 | 2 | 1 | 13-407 |
| 130 | frmCreditCustomerReceipt.cs | CSharp | SHA256 | 7db3d134475a26b32cf1365ed98f1b604506d47863cc4f03c642346c4eec404e | 491 | 111 | 1 | 31-1416 |
| 131 | frmCreditCustomerReceipt.Designer.cs | CSharp | SHA256 | 71e91bc7807d0617f0a567aa1c5aa892f5630a331ebf067a6f503c8d9e0b35b9 | 625 | 2 | 1 | 13-651 |
| 132 | frmCreditCustomerReceiptRecord.cs | CSharp | SHA256 | 663eea18bc04d1bdd4b8af088c951e1aa973929b96d601ed4ed6b30b5649beb5 | 254 | 73 | 1 | 29-884 |
| 133 | frmCreditCustomerReceiptRecord.Designer.cs | CSharp | SHA256 | b7a1f2ce1e933a1b9125e56caa6ab89cc32593bb1a1d2b23148b9fc18def784f | 420 | 2 | 1 | 13-453 |
| 134 | frmCreditCustomerRegistration.cs | CSharp | SHA256 | cb851646e3dd802bd3b5c735a61bc5e6beec3560a61aa532ce6d8aa90c368490 | 598 | 101 | 1 | 28-1546 |
| 135 | frmCreditCustomerRegistration.Designer.cs | CSharp | SHA256 | b2ee5d16c3d8a83d0590705d4b1abb099dc7304eeb917da260b1d75e7b26ee2f | 567 | 2 | 1 | 13-602 |
| 136 | frmCreditCustomersList.cs | CSharp | SHA256 | 462f5ecaf48c0a45a274ada39c4cc8863da1f83afc9ebb424263d07cfcf8463d | 166 | 36 | 1 | 28-493 |
| 137 | frmCreditCustomersList.Designer.cs | CSharp | SHA256 | a4171e3cc51ded7f573f7f8edaef456ec93f7a88ba5cb528ed2dcda15106e121 | 199 | 2 | 1 | 13-229 |
| 138 | frmCurrency.cs | CSharp | SHA256 | 7b03e4cc051f6129f4677474a6274f2c445c7b1e0a87e0ade787dff830ef5808 | 376 | 62 | 1 | 27-961 |
| 139 | frmCurrency.Designer.cs | CSharp | SHA256 | 5f11b6aac0cf995218ac42265ed627feb25809591972fa4d248c26bd3d84bcbe | 370 | 2 | 1 | 13-396 |
| 140 | frmCustomDialog1.cs | CSharp | SHA256 | d42ace91e8cc69f44ca4165269aae225416a33bbced96517d78dca80c4586c8e | 43 | 10 | 1 | 24-134 |
| 141 | frmCustomDialog1.Designer.cs | CSharp | SHA256 | 00d667be6b7aa294c55ff34a298c677f776880dfb3906f96115b144e28c4b445 | 66 | 2 | 1 | 13-87 |
| 142 | frmCustomDialog10.cs | CSharp | SHA256 | f72c8a0f8ca668ed26157add6111d2ba040047bcdf387a4caeb26f826fffac92 | 43 | 10 | 1 | 24-134 |
| 143 | frmCustomDialog10.Designer.cs | CSharp | SHA256 | 147f59326f18ec018310506d3ae6008eb27fc8e18025adba37c34e3004bbfa61 | 65 | 2 | 1 | 13-86 |
| 144 | frmCustomDialog11.cs | CSharp | SHA256 | 025e318ae51a75ad8ae46adb74c70bf53e80a41776ff75075ee263861b8db972 | 43 | 10 | 1 | 24-134 |
| 145 | frmCustomDialog11.Designer.cs | CSharp | SHA256 | 9099094a29496f9aa6eddbde6e636a1cfa2cb64e50775b1ad09f191a4d3bda2f | 65 | 2 | 1 | 13-86 |
| 146 | frmCustomDialog12.cs | CSharp | SHA256 | 1cf24d865fe775738d212dcdf4630ec2c8de7124810423c8d96e3b334e0b5ede | 43 | 10 | 1 | 24-134 |
| 147 | frmCustomDialog12.Designer.cs | CSharp | SHA256 | e56599d567c2fb6830cc7b0bd130a1f1786fdf6cb0aa9ab0b6aa428cf773f800 | 65 | 2 | 1 | 13-86 |
| 148 | frmCustomDialog13.cs | CSharp | SHA256 | ebdac3a1d412ee3bfb850b545706e9090cd87a7409078c88087a2dba72b6b362 | 43 | 10 | 1 | 24-134 |
| 149 | frmCustomDialog13.Designer.cs | CSharp | SHA256 | 21d3dca153322425e61ee2fea1d07dd395515895fdd8c3b4b6d897e4a8dfb990 | 62 | 2 | 1 | 13-83 |
| 150 | frmCustomDialog14.cs | CSharp | SHA256 | 58dd8594be50d80ecb9991ac3d9836166e482a6bc12200d2c21057369a912f4a | 43 | 10 | 1 | 24-134 |
| 151 | frmCustomDialog14.Designer.cs | CSharp | SHA256 | 536687cd3dcc57034ea21796a84aa01ec8ee0efb0e60a4e4d70c35e724ee4b5f | 64 | 2 | 1 | 13-85 |
| 152 | frmCustomDialog15.cs | CSharp | SHA256 | 3a667d55c8e237699fefb66987ec43a7f8780daceb7831e2b762e5a7b5bb2896 | 43 | 10 | 1 | 24-134 |
| 153 | frmCustomDialog15.Designer.cs | CSharp | SHA256 | 81af925c5ad45a17201df0c34533017957c99d98d1325706acfb00e13cec82de | 64 | 2 | 1 | 13-85 |
| 154 | frmCustomDialog16.cs | CSharp | SHA256 | 1f07cc4e520144c9c2eabdb600afc5d300722b4b12395c261126b257b2db4c95 | 43 | 10 | 1 | 24-134 |
| 155 | frmCustomDialog16.Designer.cs | CSharp | SHA256 | 00b16071920a065c2c0b985c16bd634e318a2790fd624e6572f7bbdf1ecd893c | 64 | 2 | 1 | 13-85 |
| 156 | frmCustomDialog17.cs | CSharp | SHA256 | 609002d2c234247fb69e3baf23d8583657ab79a7c3b595ad31eca24d79c9cce0 | 78 | 16 | 1 | 25-220 |
| 157 | frmCustomDialog17.Designer.cs | CSharp | SHA256 | 30ed87be7e935207b10d15e1498b1945deea91a0564c03717c572de1d4655a40 | 100 | 2 | 1 | 13-121 |
| 158 | frmCustomDialog18.cs | CSharp | SHA256 | 80b7b63fd47c3f416883a82de59bf4c7de5074b62956d687a43161bee3bb6004 | 43 | 10 | 1 | 24-134 |
| 159 | frmCustomDialog18.Designer.cs | CSharp | SHA256 | d8d7489bb59d48de6cf459449fca7919500fc48fbf7d119818b0945d959f8322 | 65 | 2 | 1 | 13-86 |
| 160 | frmCustomDialog19.cs | CSharp | SHA256 | 4e34282860024b6991819ad286fac643b74386645f51a897d5e2706b2d82731f | 43 | 10 | 1 | 24-134 |
| 161 | frmCustomDialog19.Designer.cs | CSharp | SHA256 | 5df68533de55e1eaba445602f3f205d52c875b6e0be4576f72bb7fd9c7964944 | 65 | 2 | 1 | 13-86 |
| 162 | frmCustomDialog19X.cs | CSharp | SHA256 | 89d762ff58da6ee390492939d2387824068cbd40c03a292b14e6ab6e9dd982e8 | 43 | 10 | 1 | 24-134 |
| 163 | frmCustomDialog19X.Designer.cs | CSharp | SHA256 | 88e5c869ef7c855d179b1b4ecaba0b4297096932fa92d6a467b19c08be71751b | 65 | 2 | 1 | 13-86 |
| 164 | frmCustomDialog2.cs | CSharp | SHA256 | 405996760da5f3adac531a65e3607162bb61ea2ba5b61f6eee5491ca91c35586 | 43 | 10 | 1 | 24-134 |
| 165 | frmCustomDialog2.Designer.cs | CSharp | SHA256 | be818bd03aa92bd085a0e583ca9345d873aaf0c25d4477dde5f16506d45140d7 | 65 | 2 | 1 | 13-86 |
| 166 | frmCustomDialog20.cs | CSharp | SHA256 | c5a03bb76367a916d880543420814bbdbbb8550f7447a4ad4dd942b7ca85562c | 43 | 10 | 1 | 24-134 |
| 167 | frmCustomDialog20.Designer.cs | CSharp | SHA256 | b51802bf3e0c8a3581b1f602aade3cdbf641f2518cb1bd9fc649b8114632269f | 65 | 2 | 1 | 13-86 |
| 168 | frmCustomDialog21.cs | CSharp | SHA256 | 9d77f523f28a7b4772b0725976f12ac23ccafaa75943375e1bd4efb767dd8a2b | 43 | 10 | 1 | 24-134 |
| 169 | frmCustomDialog21.Designer.cs | CSharp | SHA256 | e01ccad2f27e03023c92488a582bc16d5223f2952a25791bc5fc0a96f0536c42 | 65 | 2 | 1 | 13-86 |
| 170 | frmCustomDialog3.cs | CSharp | SHA256 | cf4a35284de52023d2a6a1fe22d7bfbc610a896539a84ec54f043df7beee19b1 | 43 | 10 | 1 | 24-134 |
| 171 | frmCustomDialog3.Designer.cs | CSharp | SHA256 | 02395c36e6a9a30ca98b76be65650de612add79028af0970daf8e578bd3ecca6 | 65 | 2 | 1 | 13-86 |
| 172 | frmCustomDialog4.cs | CSharp | SHA256 | e61de6f8d092f90952ef0dd365e073da734df1226c2309ea6e13db3323ec4fb0 | 43 | 10 | 1 | 24-134 |
| 173 | frmCustomDialog4.Designer.cs | CSharp | SHA256 | de8820854670f067d29bcca76b94c4df0d573f575e3445c1f8b3be5b347112b5 | 65 | 2 | 1 | 13-86 |
| 174 | frmCustomDialog4X.cs | CSharp | SHA256 | 1f006ecf2ce49d37fa62fcee50779ca18b77d4252325ddb9f4ae4af96283f8e7 | 43 | 10 | 1 | 24-134 |
| 175 | frmCustomDialog4X.Designer.cs | CSharp | SHA256 | a15a3a493add6a21a7662b2b62ab5d13d262e3c48ab2cb95ea54f4429ab1b744 | 65 | 2 | 1 | 13-86 |
| 176 | frmCustomDialog5.cs | CSharp | SHA256 | e10cdfb5f6f4d308c9310b1ac27cc92730064b90c96812d0119c09b691be677d | 43 | 10 | 1 | 24-134 |
| 177 | frmCustomDialog5.Designer.cs | CSharp | SHA256 | 1bde30815505f91df21c8c6a9fda31f899a1a50be9c27f83ef2da28c594a594b | 65 | 2 | 1 | 13-86 |
| 178 | frmCustomDialog6.cs | CSharp | SHA256 | 7a3dff36d5aa56844662e575410c025b8dba667f728d6d8a0690aa95542c9c7b | 43 | 10 | 1 | 24-134 |
| 179 | frmCustomDialog6.Designer.cs | CSharp | SHA256 | b9877e8eb771e25bb64c11c25b108df4d0d2b4946ca958b366ca2c9ab6fd155a | 65 | 2 | 1 | 13-86 |
| 180 | frmCustomDialog7.cs | CSharp | SHA256 | b5f0f1f89395599bfb12de48096e37db71a722c524f41f36dbb4c405fc0fa085 | 43 | 10 | 1 | 24-134 |
| 181 | frmCustomDialog7.Designer.cs | CSharp | SHA256 | 8ba8205bc628a3b5d81623c6ff15e21c4e344850782292553e254c0999451680 | 65 | 2 | 1 | 13-86 |
| 182 | frmCustomDialog8.cs | CSharp | SHA256 | 076c633e99690b144d497b945fda8a2a4b4dc6ac17abae75117015f7ac1c5f27 | 78 | 16 | 1 | 25-220 |
| 183 | frmCustomDialog8.Designer.cs | CSharp | SHA256 | 2194af20ddfecb3971cb5cc988ac52db02842e4d514486f95ec4c18358297d04 | 99 | 2 | 1 | 13-120 |
| 184 | frmCustomDialog8X.cs | CSharp | SHA256 | 8c9c71ff7ce1adef0beabce191ce532e9225c57c54ce76e94955fa58de8ee478 | 154 | 18 | 1 | 28-318 |
| 185 | frmCustomDialog8X.Designer.cs | CSharp | SHA256 | 448ca205dda1678b9ccfd05831cf7f9cc57fe1fa25caa1074ed284d68b97e236 | 86 | 2 | 1 | 13-107 |
| 186 | frmCustomDialog9.cs | CSharp | SHA256 | 4d38dab3703593b051a89d8ac6b78a2d183a4c37d9ffa8e50b462afa9611ef37 | 43 | 10 | 1 | 24-134 |
| 187 | frmCustomDialog9.Designer.cs | CSharp | SHA256 | f22971ae829f9bc79e1d43a57a073e69cd0f660b784e61355115bcd1c53ffc0c | 65 | 2 | 1 | 13-86 |
| 188 | frmCustomDialogWS.cs | CSharp | SHA256 | 73481230b0dd1cd7151b98416c3b55a9023bfb5e75271de424d2e81505bf82bd | 33 | 7 | 1 | 24-101 |
| 189 | frmCustomDialogWS.Designer.cs | CSharp | SHA256 | 3ce2f1da9ef6877db361a6978a95494b008910ce39066b50ca7f1ab8a5ad1017 | 48 | 2 | 1 | 13-69 |
| 190 | frmCustomDialogX.cs | CSharp | SHA256 | 7a97f350dbefec7817b5b6bf493a4f202e122dc1abbb63bdee587f865f83f00b | 361 | 27 | 1 | 31-569 |
| 191 | frmCustomDialogX.Designer.cs | CSharp | SHA256 | a8dd5f1e2d4d4f73956865ba132a5bda4fe0912fc3a1d493bb426e1d45a25d85 | 141 | 2 | 1 | 13-162 |
| 192 | frmCustomDialogX1.cs | CSharp | SHA256 | f2e6cd119aa46808474a5d90173cc7475d69d1e8a6b513ebabdf99b53f602f33 | 90 | 18 | 1 | 27-255 |
| 193 | frmCustomDialogX1.Designer.cs | CSharp | SHA256 | 28ef91e60e63aaac89c1d2116dfaaa8e0800a9ba7b8899a606bccd2a7d6c3f7b | 111 | 2 | 1 | 13-132 |
| 194 | frmCustomDialogX2.cs | CSharp | SHA256 | a88acbf92134b75e8616c5759b4a26671bd1004a85bc11d7e5b47692c9fdafed | 115 | 20 | 1 | 28-307 |
| 195 | frmCustomDialogX2.Designer.cs | CSharp | SHA256 | 3ea814653f4085e02596c27cec5ec57dcedcbcc5a27d209f3da1b7dc1105eb30 | 111 | 2 | 1 | 13-132 |
| 196 | frmCustomer.cs | CSharp | SHA256 | 0e5b518d56b5006001c4872250010e29247e664675eeea4bf3851c92ec2c2a8c | 353 | 77 | 1 | 28-1029 |
| 197 | frmCustomer.Designer.cs | CSharp | SHA256 | 9d58c1cb4ee92f8d99734cff909b3e5672be7ca89ed352a236c1c82f80210774 | 467 | 2 | 1 | 13-494 |
| 198 | frmCustomersExportImport.cs | CSharp | SHA256 | 3934c6ef8def77ea5482317038a5b8be9993d6b86dc8fc845013148a8ae23127 | 261 | 49 | 1 | 30-693 |
| 199 | frmCustomersExportImport.Designer.cs | CSharp | SHA256 | 252bd5788f4b0f28004e8d2111f2cb7ad7e836a6a2b2457fba5e64f15a9e3523 | 326 | 2 | 1 | 13-352 |
| 200 | frmCustomersRecord.cs | CSharp | SHA256 | f9250ae0da022b601b760e8a1d64cfae95cb9ee4a32e1adb5c229159f91e9c02 | 291 | 65 | 1 | 27-870 |
| 201 | frmCustomersRecord.Designer.cs | CSharp | SHA256 | 2b3b816e7bd33494883f62327f57d603ce8fae8a76ba3b0185e6cb6cff848e9e | 390 | 2 | 1 | 13-416 |
| 202 | frmDatabase.cs | CSharp | SHA256 | b8e17c340f5c6789642d737ff16ae96b25165bc01433f39ac14e5f31f1c93a91 | 134 | 20 | 1 | 28-318 |
| 203 | frmDatabase.Designer.cs | CSharp | SHA256 | c767bd7f3d2164352af14773caf27a9a56fd359601c4b5d7306f05c14936c0fa | 118 | 2 | 1 | 13-159 |
| 204 | frmDelete.cs | CSharp | SHA256 | 2ac79109e1e377affaae45279d7684b41c647550dfe0fb0e8a1b971db1c55443 | 44 | 7 | 1 | 25-110 |
| 205 | frmDelete.Designer.cs | CSharp | SHA256 | 5d4ddea50ab67b01d842de11b7c0c27eef9e3c0df120d9d576ea0fef6689b38f | 36 | 2 | 1 | 13-57 |
| 206 | frmDeliveryPersonLedger.cs | CSharp | SHA256 | 948bfa0543eda98d29a834e1b065bb06fad8abb66c5d52c99aee4366e8cfa99e | 231 | 58 | 1 | 28-709 |
| 207 | frmDeliveryPersonLedger.Designer.cs | CSharp | SHA256 | 42b99dab497839090de4a0a83e0d2da210a5a1843a505593ab4df5cf17a19300 | 325 | 2 | 1 | 13-346 |
| 208 | frmDeliveryPersonRecord.cs | CSharp | SHA256 | 42c6e0e65a732fabb6488c876fa8d829227e7b8fa05eec61a195a188ecba25dc | 178 | 53 | 1 | 27-621 |
| 209 | frmDeliveryPersonRecord.Designer.cs | CSharp | SHA256 | 7fb769dc3a45f3e7aca1a0bc6689244e9831dd393a0bfbce8be7037f20778680 | 296 | 2 | 1 | 13-327 |
| 210 | frmEInvoicePreview.cs | CSharp | SHA256 | 5ade7906db78c6ebe19e0b483691d1a4c1b3bd56f44093c59ca84ee074fa5e78 | 84 | 7 | 1 | 19-117 |
| 211 | frmEmailSetting.cs | CSharp | SHA256 | d342c543e2bfa74e2ada2d0941b53ef64a7c961f2849d34f9756eee300ea8141 | 430 | 82 | 1 | 28-1189 |
| 212 | frmEmailSetting.Designer.cs | CSharp | SHA256 | c80a768f8a1247686f7b094e737f2e7c057e14655b7166d9889984b5276db064 | 433 | 2 | 1 | 13-476 |
| 213 | frmEmployeeRegistration.cs | CSharp | SHA256 | 05fa32c05bffddbf5b77a7b307baf85b55740a8f6366a52176fe5d380ae90d1b | 368 | 84 | 1 | 31-1111 |
| 214 | frmEmployeeRegistration.Designer.cs | CSharp | SHA256 | 99112f9391869a6d9ce7929abb5bd59bcc09b9439f0d1da39dd8a6fa92909b69 | 500 | 2 | 1 | 13-521 |
| 215 | frmEmployeeSession.cs | CSharp | SHA256 | 22b645b1eaaae76dfd337a055a9c1ece3b7b9a12695692fb0714b0d88d5324dc | 237 | 59 | 1 | 27-727 |
| 216 | frmEmployeeSession.Designer.cs | CSharp | SHA256 | 5b80512973b5acba09170d831ca679168271a852983eef5a15d97d4132768156 | 341 | 2 | 1 | 13-369 |
| 217 | frmEmployeesRecord.cs | CSharp | SHA256 | c724e7b9ab91639f22e00a4e2e90d8fa8261fc240ca39b8fd330b3854e6b8dd3 | 208 | 54 | 1 | 28-678 |
| 218 | frmEmployeesRecord.Designer.cs | CSharp | SHA256 | 0e33031c027859491783407acd65d3acf21dfaed9d6f197d02e6515f0a6796ad | 298 | 2 | 1 | 13-330 |
| 219 | frmEnterQty.cs | CSharp | SHA256 | e3bea9121f2f92dd28df719d032c7bc453176a0c34697e11408fdac0380fe441 | 418 | 67 | 1 | 29-1038 |
| 220 | frmEnterQty.Designer.cs | CSharp | SHA256 | c878378a4a62d3a789376a49f2184688e894dba53503bd7d7c6b77b3893d8e70 | 546 | 2 | 1 | 13-717 |
| 221 | frmEnterQtyX.cs | CSharp | SHA256 | 1a21800876a7c0dcd1a86854dfc3387352ea8d64713638707ac548191f702e40 | 417 | 67 | 1 | 29-1037 |
| 222 | frmEnterQtyX.Designer.cs | CSharp | SHA256 | 1622de0b21870f0cf8ee50f0a3786301a507660a1d20183dd2a4fa71f44b6673 | 546 | 2 | 1 | 13-717 |
| 223 | frmExecuteQuery.cs | CSharp | SHA256 | 4822e77168a7cafb02baade72dab9742c5d3d6903d6f3a50b343bee013cf2cfd | 80 | 16 | 1 | 28-230 |
| 224 | frmExecuteQuery.Designer.cs | CSharp | SHA256 | 80e5a450921606fa1ac1a4a1f274502e108752fe2db073e8dadb4717316c2aaa | 75 | 2 | 1 | 13-96 |
| 225 | frmExpense.cs | CSharp | SHA256 | cf4bec99b42b123fdd19747eee74a6505cb68ed965d5e58b40b80842a9cb2ad0 | 339 | 63 | 1 | 29-904 |
| 226 | frmExpense.Designer.cs | CSharp | SHA256 | 9619ee7cc05e151c87bc61388a33bb25d8465df522115338b9d651dd9d093ad4 | 377 | 2 | 1 | 13-402 |
| 227 | frmExpenseType.cs | CSharp | SHA256 | a63510d7420c90cf612efc08c4165a8501123bda279b90eb5766288077aea103 | 256 | 45 | 1 | 27-673 |
| 228 | frmExpenseType.Designer.cs | CSharp | SHA256 | 41428fa541cbfe12c60e5952039bf6acaa4d954ad8d9b624994e41629c8dd9a7 | 295 | 2 | 1 | 13-319 |
| 229 | frmExpiredProductsRecord.cs | CSharp | SHA256 | cefbbda94c6f959c598de28b2ab139b19432e7431635c121754314530073ac32 | 191 | 53 | 1 | 27-653 |
| 230 | frmExpiredProductsRecord.Designer.cs | CSharp | SHA256 | 277f8a7d9531eaeee3fae0421ee4fc7b78f5c8e73a5e1852a2126d5662e6f523 | 323 | 2 | 1 | 13-351 |
| 231 | frmFreeToppingsList.cs | CSharp | SHA256 | 1a20aace752a0668c62a96f884723696d80654fda8122411d154d412248118e3 | 253 | 25 | 1 | 29-507 |
| 232 | frmFreeToppingsList.Designer.cs | CSharp | SHA256 | 7a90268d0028acf9232de4e98d64e92d3d2c94bd8bfdfc4bdf32b44f760acd2d | 106 | 2 | 1 | 13-127 |
| 233 | frmFrontOffice_Report.cs | CSharp | SHA256 | 257a4c3046024d184418082ff49684ccd2b9e21bf65b92e36148b15ff32b7660 | 71 | 20 | 1 | 25-239 |
| 234 | frmFrontOffice_Report.Designer.cs | CSharp | SHA256 | 52f4692505236165fb26091e18c9943943a13625a2fe9ba7c76fd2cfd5c0d439 | 113 | 2 | 1 | 13-134 |
| 235 | frmFrontOffice.cs | CSharp | SHA256 | 1a0e1008559cf24044fb5e18978c227ab836a0b3470f2b9be84ff90863645239 | 370 | 62 | 1 | 31-908 |
| 236 | frmFrontOffice.Designer.cs | CSharp | SHA256 | de341740eac3fc511da9b93a73f0457709b6ff6fc48c801c6412f598e1992394 | 524 | 2 | 1 | 13-605 |
| 237 | frmFundDeposit.cs | CSharp | SHA256 | abd11950e4b487c9e8540e59a0cfc59248cb3e4cda21d698b1dcbab099aa88f6 | 620 | 141 | 1 | 31-1843 |
| 238 | frmFundDeposit.Designer.cs | CSharp | SHA256 | 6b130bce495ddaea6ababcc014bc14fb33ecab471c83d9092ae713a1122f7c1b | 751 | 2 | 1 | 13-785 |
| 239 | frmFundTransfer.cs | CSharp | SHA256 | 55d60cf65566d5621d7d1ea654ba1c425b65412cd8e1a9efd377fd50b2ee34a8 | 601 | 155 | 1 | 29-1907 |
| 240 | frmFundTransfer.Designer.cs | CSharp | SHA256 | 8ebba13890c2320a91b76ff4f5ebb139144f933796d1e2a3f655c63aa0ca5ef0 | 889 | 2 | 1 | 13-919 |
| 241 | frmGeneralLedger.cs | CSharp | SHA256 | 44c1d3a28cd068e926949b4d1ed8ae50e35c0ef5d63aa183945839698ed25400 | 177 | 44 | 1 | 30-535 |
| 242 | frmGeneralLedger.Designer.cs | CSharp | SHA256 | 5ef54c8df8d21aa06bddcb6937c705ac997e81efef93bc011f55aeacd295d043 | 232 | 2 | 1 | 13-253 |
| 243 | frmGiftCard.cs | CSharp | SHA256 | b7afabe17722914089718f9fd7fe1092b114c770e33b7aac9aa48c61fa45f141 | 397 | 68 | 1 | 31-1023 |
| 244 | frmGiftCard.Designer.cs | CSharp | SHA256 | c1b40e277251263ac3b394b33e1e3ad5b1687e7f15b421b537c1f7ddacfde606 | 385 | 2 | 1 | 13-412 |
| 245 | frmGiftCardRecord.cs | CSharp | SHA256 | fccd09f52a1cec7b7d5d88a8fb24fc1484753a0b4e344ac85f6ecfac17c400cc | 150 | 27 | 1 | 27-398 |
| 246 | frmGiftCardRecord.Designer.cs | CSharp | SHA256 | 3a0753303835aca3f30da72e08d3feb7ad77dcb0ddf532e58e6ce06fca3edcc4 | 185 | 2 | 1 | 13-211 |
| 247 | frmHDStatus.cs | CSharp | SHA256 | 10d6aa81995e85a210a1b987c267935047b9c1823a8c100cb291426c03fe8b63 | 148 | 25 | 1 | 27-391 |
| 248 | frmHDStatus.Designer.cs | CSharp | SHA256 | 064c705316de038c1504d26ccf6f0548a44cadbc06ceeab1ff987c7cb0cb8619 | 145 | 2 | 1 | 13-166 |
| 249 | frmHoldBills.cs | CSharp | SHA256 | 45b239eaa281a80ec7833bfb606a9440d6f7c9eae9ec764af8ebb2b2ecc878c0 | 207 | 29 | 1 | 27-529 |
| 250 | frmHoldBills.Designer.cs | CSharp | SHA256 | 74e705b205b13d2122d439ec6c4946457fb991dc9d4cbfb6aeb0d89fd975f4c6 | 179 | 2 | 1 | 13-208 |
| 251 | frmHoldBillsHD.cs | CSharp | SHA256 | 4c8445e9e81c1d8adc02dafda0ecac45c579dfb3c3fdbc2fe00503c5fb56c048 | 152 | 31 | 1 | 27-447 |
| 252 | frmHoldBillsHD.Designer.cs | CSharp | SHA256 | cd12538326949f0592ad48d60f7734ae63336ad23b75508b18b920df63c5b7ba | 181 | 2 | 1 | 13-211 |
| 253 | frmHoldDineInKOTs.cs | CSharp | SHA256 | faf32740aa63b8839014946812197900c42dbbbead5b95d3e5952831005e2df7 | 145 | 27 | 1 | 27-410 |
| 254 | frmHoldDineInKOTs.Designer.cs | CSharp | SHA256 | 26721527e110401789347cbc5be23b6fe8d4221b0c75565ade6c381c0a1f58ef | 166 | 2 | 1 | 13-195 |
| 255 | frmHomeDelivery.cs | CSharp | SHA256 | 31421b69a494260ba3416be2c923fab9f149ce04dec5b579bbff4512293be72c | 70 | 18 | 1 | 25-223 |
| 256 | frmHomeDelivery.Designer.cs | CSharp | SHA256 | beaef5dd7e8cb7c87af73e9027d4e2e2f6871c88e16480dced748146db536b92 | 98 | 2 | 1 | 13-119 |
| 257 | frmImportExportExcel_Products.cs | CSharp | SHA256 | d20209ff921da0e986e54c94da2af8e24017d94e8c73c56aaa48453bf1405713 | 378 | 70 | 1 | 31-985 |
| 258 | frmImportExportExcel_Products.Designer.cs | CSharp | SHA256 | 8e8fa88a3a44edc3b89caba2c4d81c8811dea0c4fe021cd85766967bf33607f3 | 392 | 2 | 1 | 13-428 |
| 259 | frmImportExportExcel_Supplier.cs | CSharp | SHA256 | a1482c974bc0496fab207ec0cb75ad5edb63db00f7c37654df77a3105c7bc643 | 350 | 80 | 1 | 31-1049 |
| 260 | frmImportExportExcel_Supplier.Designer.cs | CSharp | SHA256 | fdb9977003f5c8f965ec76efd70672fbe13ddf244b9ff56a45ddb7b1cb128583 | 409 | 2 | 1 | 13-450 |
| 261 | frmItemsTransfer.cs | CSharp | SHA256 | afdddb59f30e4b098e921c588775233d0916205718fc93d0525f602131496548 | 565 | 122 | 1 | 29-1602 |
| 262 | frmItemsTransfer.Designer.cs | CSharp | SHA256 | e0c14d72c29fe09335e5b3db9ade84763db9e19ba5eecdb9562571dbf51f235b | 643 | 2 | 1 | 13-703 |
| 263 | frmJournalEntries.cs | CSharp | SHA256 | de88cdbcd7c55bf9e7d54130bd3cf69042de6c9414d1fb12bc6cdf664ee742a1 | 533 | 125 | 1 | 27-1601 |
| 264 | frmJournalEntries.Designer.cs | CSharp | SHA256 | 0a6c085f5e186eca8a39dca2045e1bcc09a3b370e7af9e9e67c0ff07834f340c | 668 | 2 | 1 | 13-697 |
| 265 | frmKDS.cs | CSharp | SHA256 | b609d768c26b28282048b4ce3cc9c0df5ae49b0830e3dea961bcb3d6b1118a98 | 341 | 46 | 1 | 30-745 |
| 266 | frmKDS.Designer.cs | CSharp | SHA256 | 3c8b6f58ee61bef1d34ff1788e404f41c70b6db92ee742256f0d4ea1f951d11c | 197 | 2 | 1 | 13-228 |
| 267 | frmKitchen_Section.cs | CSharp | SHA256 | 25c4578358d70bbe1a74bf7ccfa9755171bac26c14844cc7099546b42fb76802 | 444 | 70 | 1 | 29-1051 |
| 268 | frmKitchen_Section.Designer.cs | CSharp | SHA256 | 140e1df28500013a39b1c1deb6e00d28093fe793d4a142a11f5d44a902af1e78 | 420 | 2 | 1 | 13-446 |
| 269 | frmLogin.cs | CSharp | SHA256 | bb664ef305372a149fa0968a900c442a370c10e77080a902d53f1ad0a1e13ecb | 631 | 120 | 1 | 35-1619 |
| 270 | frmLogin.Designer.cs | CSharp | SHA256 | 29c62d8874d078c16e7818154bf4349e6055dbbe47571b01bd5efb4803a58338 | 744 | 2 | 1 | 13-889 |
| 271 | frmLogs.cs | CSharp | SHA256 | ca729996b5c9ed6252c07a1194363c8bbe80976d341ff2fe1b9a1f5098dc0f23 | 313 | 77 | 1 | 27-955 |
| 272 | frmLogs.Designer.cs | CSharp | SHA256 | f5c4f46b12df8af545286acc38a49d897289ff3a22fef36abdff978df0e6f32d | 459 | 2 | 1 | 13-485 |
| 273 | frmLowStockRecord.cs | CSharp | SHA256 | 5699c41edce67e62bb40d2a599286e508a7118f29146030e0adeecdcb87e14b5 | 154 | 42 | 1 | 26-523 |
| 274 | frmLowStockRecord.Designer.cs | CSharp | SHA256 | 8a27d4d9f17c3519b2f638e0d711dc20518efddaf17dfd6ebda0b8818595f74a | 249 | 2 | 1 | 13-278 |
| 275 | frmLoyaltyCard.cs | CSharp | SHA256 | 8cb64f949140a3b74c85912248c296eb397c20c96098ac5a28c330381f7daa73 | 89 | 20 | 1 | 25-258 |
| 276 | frmLoyaltyCard.Designer.cs | CSharp | SHA256 | 76315c2d1e1bc7d9b603d33d17a31b25fffee17030a4a751f4681901c923d89b | 138 | 2 | 1 | 13-159 |
| 277 | frmLoyaltyCardMemberLedger.cs | CSharp | SHA256 | b4f97ec28cb6217d8ddca219d07efa7d9f71730efb6a6bd6faa83e9e9e0b93c6 | 273 | 63 | 1 | 29-794 |
| 278 | frmLoyaltyCardMemberLedger.Designer.cs | CSharp | SHA256 | 7000f67fde47c02aa02f7a0df58dfaa6ce9f7a5dbdb8187345d4cce355a2e5ee | 359 | 2 | 1 | 13-380 |
| 279 | frmLoyaltyCardMemberList.cs | CSharp | SHA256 | 77faa58d8213910967ada9e12b54f5e0e2746241c5859612011918fa0ec5fe80 | 118 | 29 | 1 | 27-377 |
| 280 | frmLoyaltyCardMemberList.Designer.cs | CSharp | SHA256 | adea87bc6c9375a82606344d9bcd7e8723be3513cc8bb1d03cb82371533e0ad4 | 158 | 2 | 1 | 13-188 |
| 281 | frmLoyaltyCardMemberPoints.cs | CSharp | SHA256 | 16549deca6421547f6ad2192a74456f3f4b218619bde598662e3c8a630da6703 | 250 | 48 | 1 | 26-685 |
| 282 | frmLoyaltyCardMemberPoints.Designer.cs | CSharp | SHA256 | 674dea494659af2c2b98522a840cd6a5c50888da932ed1b9f543fe3349f6dee1 | 285 | 2 | 1 | 13-313 |
| 283 | frmLoyaltyMember.cs | CSharp | SHA256 | bdb6cacd712a3545cfbb8f5e650a0810a97cf935c87507011f0d78dff19f2ee0 | 409 | 84 | 1 | 27-1185 |
| 284 | frmLoyaltyMember.Designer.cs | CSharp | SHA256 | 3c9a1a4591c10954a08fba30c5aae3737729a18adae3b183b66d398b5d48119d | 478 | 2 | 1 | 13-508 |
| 285 | frmLoyaltySetting.cs | CSharp | SHA256 | 75cad1d1848f2f0e3c30f60e3a44b94d4acf41f55d0d367fd0099d40ab2adb10 | 343 | 59 | 1 | 26-903 |
| 286 | frmLoyaltySetting.Designer.cs | CSharp | SHA256 | 20e88ae6cdbf8f6fc3acd04779549d6024e52d2e645ccaf32a4fedb01e04e00a | 367 | 2 | 1 | 13-393 |
| 287 | frmMarketingTools.cs | CSharp | SHA256 | 8c3d84a6fa068aeaf71921607b6c926bf739c3aff59da683044d5181b1779666 | 65 | 16 | 1 | 26-204 |
| 288 | frmMarketingTools.Designer.cs | CSharp | SHA256 | 10b10dcf90ca37ef98aaeafc344c8d379cc1277e225844366b6e16a35b5d10f4 | 103 | 2 | 1 | 13-144 |
| 289 | frmMember.cs | CSharp | SHA256 | e7fe9ae05accdba2062d5f66385318b3955b6c6e234941c4ee4da07db729779a | 403 | 78 | 1 | 26-1129 |
| 290 | frmMember.Designer.cs | CSharp | SHA256 | 6ed7927f7cf591b9d56f6e375cafa47f62c9724c6cea5cb0bd6dde1644c20ba6 | 450 | 2 | 1 | 13-479 |
| 291 | frmMemberBalance.cs | CSharp | SHA256 | e88a185bc3039ad245ad0a4ebd510654db1d7936cd9dcd8726505eba5e06d5c8 | 275 | 47 | 1 | 27-725 |
| 292 | frmMemberBalance.Designer.cs | CSharp | SHA256 | 448889fd85fda6b223c7ecae509c6fc6064e27ffd5f44d94d8ab2cee7df95df9 | 293 | 2 | 1 | 13-320 |
| 293 | frmMemberLedger.cs | CSharp | SHA256 | f1cc149c331b68f58ebd74361912c31f7cc3109c77a4647610b24f2f6bed1e57 | 267 | 63 | 1 | 28-787 |
| 294 | frmMemberLedger.Designer.cs | CSharp | SHA256 | e0211647e078e1f674e580046c32b2a79f00484717c6721b066d76d3f6934120 | 359 | 2 | 1 | 13-380 |
| 295 | frmMemberList.cs | CSharp | SHA256 | e259c8dd2adf934f28ce4608017280e1f71b445644734ce0bd48bf70908af5c1 | 115 | 27 | 1 | 27-357 |
| 296 | frmMemberList.Designer.cs | CSharp | SHA256 | f3eb0500657754dd8975d770eca8639880b8c89197b2d1c99b88f6653e4482ae | 152 | 2 | 1 | 13-181 |
| 297 | frmMenuItem.cs | CSharp | SHA256 | 39c42e6fae8733a2c41aabfae69da6f635e789a02a3a41963764e09d2e2a3f06 | 863 | 156 | 1 | 32-2340 |
| 298 | frmMenuItem.Designer.cs | CSharp | SHA256 | 3848f1876d5e26c79829dabd0eb3d71c72f96a58d1fca70447396c6cc3cd7f79 | 853 | 2 | 1 | 13-901 |
| 299 | frmMenuItemsCategory.cs | CSharp | SHA256 | ec3ac069e36a6e4c022938a19f15684250eca30b76cd544bd0586e44cb09f0e2 | 520 | 88 | 1 | 29-1348 |
| 300 | frmMenuItemsCategory.Designer.cs | CSharp | SHA256 | 0afe35c829430c8d2194e17b8b448fc15c988970b14530c5d255ad125e30e5b7 | 490 | 2 | 1 | 13-519 |
| 301 | frmMenuItemsExportImport.cs | CSharp | SHA256 | cb91fb145f3c1f819172f79805e53d95d25604b290979e963ff68fb336d0208b | 361 | 68 | 1 | 33-989 |
| 302 | frmMenuItemsExportImport.Designer.cs | CSharp | SHA256 | df9efa1a6c080eeb9c01c08831ec9abcbe34d3c76a56e18d944c91b72fc8d44d | 408 | 2 | 1 | 13-438 |
| 303 | frmMenuItemsList.cs | CSharp | SHA256 | bc03f88ac1401564552c32e37eaa5fd5ccfc0cfe1fefe48e979c71258a205768 | 133 | 29 | 1 | 26-391 |
| 304 | frmMenuItemsList.Designer.cs | CSharp | SHA256 | f730f63a06ba3a20ab092d1fb5663cef4694c65ecdc7de330cd66cc42101c3e3 | 139 | 2 | 1 | 13-164 |
| 305 | frmMenuItemsModifiers.cs | CSharp | SHA256 | 169ffbaa76c8f7561c7323602fefd446b8e69df5f06c80f6dc143dce265ed56b | 497 | 90 | 1 | 29-1337 |
| 306 | frmMenuItemsModifiers.Designer.cs | CSharp | SHA256 | 4b6a60e2f0c793fbb62375e0fc9d3249d28230db82fdaedb1d597e0a5a4a7f3f | 480 | 2 | 1 | 13-508 |
| 307 | frmModifiersExportImport.cs | CSharp | SHA256 | f52d10cd37729325049687b238b3da2acf3a8ab31cbe0a78fcae60912be06189 | 222 | 42 | 1 | 31-586 |
| 308 | frmModifiersExportImport.Designer.cs | CSharp | SHA256 | 442be9ea214e16f7bd91c1d92adc6fe3fd26003e15dace6a8d4e92baafa25508 | 284 | 2 | 1 | 13-310 |
| 309 | frmModifiersList_AutoPopUp.cs | CSharp | SHA256 | b20234fe2eee3ea7bfddfac3d4abb23a4b6cf6a677cba51c0a2714cec21b5c01 | 262 | 34 | 1 | 28-650 |
| 310 | frmModifiersList_AutoPopUp.Designer.cs | CSharp | SHA256 | a66bab995666d06ac39f166b4e58218b16adff8837b7317a6642cf671eabba15 | 174 | 2 | 1 | 13-195 |
| 311 | frmModifiersList.cs | CSharp | SHA256 | 8936a0976959cf349230bd46eb94ebf896598c049497a54c8ae14f87e51d84b5 | 425 | 49 | 1 | 29-957 |
| 312 | frmModifiersList.Designer.cs | CSharp | SHA256 | 50df168a47dbca6c3f96b177c9e2e25774641fe07975737a474e606afe170228 | 281 | 2 | 1 | 13-307 |
| 313 | frmMpesaSetting.cs | CSharp | SHA256 | 9dd2132f5196e1f5cd32c9852a586d7d98cc8c372025e3aed1c422341e9959f4 | 170 | 39 | 1 | 27-508 |
| 314 | frmMpesaSetting.Designer.cs | CSharp | SHA256 | 67184da7eb237a2cec624e9b29d5276f9e35d1052a90e677b80a5a491ca34862 | 251 | 2 | 1 | 13-272 |
| 315 | frmNotes.cs | CSharp | SHA256 | 81c0abdda66ba9c1eec71b1d4d2bac560bab5ff375595faa3ba0ab202c8295e7 | 194 | 33 | 1 | 29-446 |
| 316 | frmNotes.Designer.cs | CSharp | SHA256 | cb922b81d6d3d91e459e6aeaaf7a2744364526bc8f49f8231ab2d23d458aa4ae | 144 | 2 | 1 | 13-165 |
| 317 | frmNotes1.cs | CSharp | SHA256 | ef4d4926fd082393373926ce0e1f7933b436cf308237c7a9fb028d41f430d6e5 | 150 | 32 | 1 | 29-411 |
| 318 | frmNotes1.Designer.cs | CSharp | SHA256 | 6b7bf7ca7a85b8dac4d5a069b94e1c00ef527baf0fb32091bfaaa72145c0b3a0 | 145 | 2 | 1 | 13-166 |
| 319 | frmNotesMaster.cs | CSharp | SHA256 | 215f683e4ae5386ebaf4ed4542bc0b96bde79fd828a0ea4d5adcb221ab5e55ad | 238 | 45 | 1 | 27-651 |
| 320 | frmNotesMaster.Designer.cs | CSharp | SHA256 | b4e3b0cce59bb53555b0398df63ff149492a51d7289add5f2599a05ef14ddb8c | 280 | 2 | 1 | 13-305 |
| 321 | frmOnscreenKeyboard.cs | CSharp | SHA256 | b2104fd9aeb3406bdd16c232fef94699caee65edcee13794af46c9f02ae40f1b | 798 | 106 | 1 | 27-1980 |
| 322 | frmOnscreenKeyboard.Designer.cs | CSharp | SHA256 | dd5a47d0e3f709fd8c42a5a5c7c3616a0a3f184590686bf9ead4e6870f9cbe6a | 1356 | 2 | 1 | 13-1777 |
| 323 | frmOpenItems.cs | CSharp | SHA256 | 571ef0075b7dbcf73836ae631635a3ec19d9d5d6028e7d42262848da9d9e8de9 | 239 | 28 | 1 | 29-604 |
| 324 | frmOpenItems.Designer.cs | CSharp | SHA256 | 5f2c492fddc9f64eccd1944cc360df342346bc1ce727edc31757807106659840 | 138 | 2 | 1 | 13-159 |
| 325 | frmOpenTicketsRecord.cs | CSharp | SHA256 | e631caa32b7c2fcbf56bdc8267d6d3f7d2df0393fc04d50146f6fdf4a0d79587 | 297 | 65 | 1 | 28-871 |
| 326 | frmOpenTicketsRecord.Designer.cs | CSharp | SHA256 | 899876d9504968b146a0368c4aa27d64302f312edbe61c63d8f746dc86cec365 | 360 | 2 | 1 | 13-394 |
| 327 | frmOption.cs | CSharp | SHA256 | 5b0be263fa985d021e728f34e89f2c476c0f5a3078e22771bb9cfbfeda536871 | 165 | 32 | 1 | 32-447 |
| 328 | frmOption.Designer.cs | CSharp | SHA256 | 654619adae84e995c372536f51ee22c789ecff168eda83595a3a04dc08b2c47d | 195 | 2 | 1 | 13-242 |
| 329 | frmOrderedItemDetails.cs | CSharp | SHA256 | b1da8f8a2d1d9aadeb26fdf526699401d5e9811cac1476aa4941f87ce70e4085 | 71 | 32 | 1 | 24-323 |
| 330 | frmOrderedItemDetails.Designer.cs | CSharp | SHA256 | 645024d9afb042ad637ed7ecab5134578a4b44472ffaa65d2bdd5c0d61622450 | 186 | 2 | 1 | 13-222 |
| 331 | frmOthersSetting.cs | CSharp | SHA256 | a1044ffd17005d1660e6841566c2ea4288963017537920e8cd7fccc509cea3aa | 709 | 141 | 1 | 27-2046 |
| 332 | frmOthersSetting.Designer.cs | CSharp | SHA256 | 3e837b692efd471b74b5e1479053b5053344b996bdc3a42c78a602303c30565b | 736 | 2 | 1 | 13-784 |
| 333 | frmPayment_Withdrawal.cs | CSharp | SHA256 | 3d0e0330a75dbfc4de21eb8eaca0d875b04533c71876427631ddda7593884ca6 | 586 | 146 | 1 | 31-1818 |
| 334 | frmPayment_Withdrawal.Designer.cs | CSharp | SHA256 | 2fa8b8a11509c035746b47d922fab511374a896636c81b1af932f0fc062ba3c5 | 798 | 2 | 1 | 13-834 |
| 335 | frmPayment.cs | CSharp | SHA256 | fe4d5ea2fc39ebe5b40e3f18bdbf147d1769bb73de2156df486fa31c928ac3f0 | 505 | 113 | 1 | 30-1462 |
| 336 | frmPayment.Designer.cs | CSharp | SHA256 | bb205f62f48d5b08d3294cd6d03b8aefeb4df135f5d21e411a2b9bcaa3b4f3ea | 641 | 2 | 1 | 13-667 |
| 337 | frmPaymentRecord.cs | CSharp | SHA256 | c1f7a0c03612193f1054d4a1c41923373d9508a13e45d453eeb1fec5929358db | 250 | 72 | 1 | 29-874 |
| 338 | frmPaymentRecord.Designer.cs | CSharp | SHA256 | 3929b6deda5b865b4d8734f2ae48fa0de7d4981f5aeb4b270790434712a95e12 | 427 | 2 | 1 | 13-460 |
| 339 | frmPayroll_HB.cs | CSharp | SHA256 | 37315b790302c3cad5a6cadef9fdf0e0c8481b51f1582da34a0f2ca8a4f54408 | 659 | 152 | 1 | 28-1928 |
| 340 | frmPayroll_HB.Designer.cs | CSharp | SHA256 | 0787aa42a4f48c8aee3780e9f16ed8eefbaea4496d7cc24457d390efe703d6cf | 864 | 2 | 1 | 13-895 |
| 341 | frmPayroll_MB.cs | CSharp | SHA256 | cbeaf734f1ba657b14205548de6adb9cc8a83c38fe391f14400fef2a3a202c99 | 659 | 152 | 1 | 27-1939 |
| 342 | frmPayroll_MB.Designer.cs | CSharp | SHA256 | f4d4b8f72df181acb6678eaedfbee7b6ac15e036f580f3f3c65bc19b42f1912f | 858 | 2 | 1 | 13-903 |
| 343 | frmPayroll_MBRecord.cs | CSharp | SHA256 | 1ada0b6d2085cd62ab450f7b75dbe25460d1a35505eaffe9c984c7d90e63fb69 | 214 | 49 | 1 | 28-614 |
| 344 | frmPayroll_MBRecord.Designer.cs | CSharp | SHA256 | a02ac1c73f7aa6a18be97ece3a9268428efb0728d906b0188b06fceda40b7b3c | 328 | 2 | 1 | 13-349 |
| 345 | frmPayroll.cs | CSharp | SHA256 | 62cd78928e4c97aaed2fc18be65e5a3c63f2fe9a756d96472f35493c9d9a8b6f | 64 | 14 | 1 | 27-189 |
| 346 | frmPayroll.Designer.cs | CSharp | SHA256 | 20091ba88078192aa378fd9f349e93217f6c8eff6fe12342682af75725dc826a | 111 | 2 | 1 | 13-152 |
| 347 | frmPayrollRecord_HB.cs | CSharp | SHA256 | 87d37aad6a988683962d68fac3a59a0d9423ccbd94a406cee12e110e8a6218c4 | 216 | 50 | 1 | 28-620 |
| 348 | frmPayrollRecord_HB.Designer.cs | CSharp | SHA256 | dbd976fba97c97c08d4e27320db4e283f70a36c5926c7cb4d0c20afc593e7c7a | 328 | 2 | 1 | 13-349 |
| 349 | frmPizza.cs | CSharp | SHA256 | aee4cec80aa80638824165fc9c0445bcabc7139e4486984ce9adff7770f907e3 | 99 | 20 | 1 | 27-291 |
| 350 | frmPizza.Designer.cs | CSharp | SHA256 | cbae0f97c8f22012a393b9c90530432a524532de39d20e38b6104c436a2ed387 | 195 | 2 | 1 | 13-256 |
| 351 | frmPizzaMaster.cs | CSharp | SHA256 | 5049d6a4ee5d63f78b7713eb2f2ec8b8624f85eec9826e21812d9925d14794c3 | 534 | 98 | 1 | 29-1477 |
| 352 | frmPizzaMaster.Designer.cs | CSharp | SHA256 | 9ec620235bd150db61528b269bc69a04bfec1e18ccb743362da2aaf19b679eac | 515 | 2 | 1 | 13-545 |
| 353 | frmPizzaModifiers.cs | CSharp | SHA256 | efdef45b8919fc7907a2521645a7f4260fcfb96c689847394438bdb6a3d5484a | 526 | 94 | 1 | 29-1427 |
| 354 | frmPizzaModifiers.Designer.cs | CSharp | SHA256 | d7e15569e9c373d840405e87a11d3d696a93aa3ee5ff48ee82c2b4f8e4d9a23a | 480 | 2 | 1 | 13-510 |
| 355 | frmPizzaModifiersList_AutoPopUp.cs | CSharp | SHA256 | 82a98f181664dcff09a873135079ad45e22a727c6915adde1848e95766c7dff8 | 292 | 55 | 1 | 28-804 |
| 356 | frmPizzaModifiersList_AutoPopUp.Designer.cs | CSharp | SHA256 | 74d39b7b90772e58096c3a4670575a905c4d4201d0bbfe636c57f224ee2d1528 | 285 | 2 | 1 | 13-319 |
| 357 | frmPizzaModifiersList.cs | CSharp | SHA256 | ef71d67b4fdd8400257cfa22a591cd84abdd169e2c13109638d5db0f26dae45e | 305 | 55 | 1 | 28-830 |
| 358 | frmPizzaModifiersList.Designer.cs | CSharp | SHA256 | f3a3e75565bb50ec5720a283295e8371130eb287f7db7b5182d4c3a339e6ff08 | 286 | 2 | 1 | 13-320 |
| 359 | frmPizzaPOS.cs | CSharp | SHA256 | c739578ef6a2f9f0d632e27961d10b4d936600b55bb76758d8fb164717b776c3 | 905 | 116 | 1 | 30-2100 |
| 360 | frmPizzaPOS.Designer.cs | CSharp | SHA256 | 4849c1f7f684f6fb8fff85b51751b60d2a82217dd6ba63a82cb20d27156aac28 | 685 | 2 | 1 | 13-812 |
| 361 | frmPizzasExportImport.cs | CSharp | SHA256 | 57be4116a7cc6141db5ae460c28059b174195eb8b1fc59e50824963db572e7bc | 265 | 47 | 1 | 30-693 |
| 362 | frmPizzasExportImport.Designer.cs | CSharp | SHA256 | 2b43031c2029daf5daf7bd98d5f096e4b85d2dd72409f1d8e12de2186286c206 | 306 | 2 | 1 | 13-333 |
| 363 | frmPizzaSize.cs | CSharp | SHA256 | 7b98564a0f81827f470aeaaa761892566002048017619fe7e12017df2bb267d1 | 257 | 45 | 1 | 26-696 |
| 364 | frmPizzaSize.Designer.cs | CSharp | SHA256 | 2e7e8b1cb0886d2bcd8942695acaf7f8defab1935e8ab77201cad83aa586f479 | 294 | 2 | 1 | 13-318 |
| 365 | frmPizzaToppings.cs | CSharp | SHA256 | 3a5fa6ce3a12e9c77a9ff18fbf869af424bb99838ae3cfc03c7f178f28abd751 | 484 | 91 | 1 | 28-1349 |
| 366 | frmPizzaToppings.Designer.cs | CSharp | SHA256 | b413092883063bf96f017cb9a85d2d6b462d10b99eed696b6c454bdde46fba70 | 480 | 2 | 1 | 13-514 |
| 367 | frmPizzaToppingsExportImport.cs | CSharp | SHA256 | f054d08518881e95ee9a3344a5d95b7dbb7d059ec89e4f5fa2c1e8ecb5d9d8b7 | 225 | 44 | 1 | 30-625 |
| 368 | frmPizzaToppingsExportImport.Designer.cs | CSharp | SHA256 | 9b5373d9d5894f312d843b8b06ad790d1036074a009fab9f9729ab0d7f68f6c4 | 288 | 2 | 1 | 13-315 |
| 369 | frmPO_CRViewer.cs | CSharp | SHA256 | 028849420f49921fd5c807abc7846d0d5d366f6a7ec0003fe8a72f511c6cdf5f | 143 | 19 | 1 | 31-336 |
| 370 | frmPO_CRViewer.Designer.cs | CSharp | SHA256 | c7f21d1ed9dc749468dba448b55631c8052fda130d3f062e20b3613a17e13011 | 101 | 2 | 1 | 13-122 |
| 371 | frmPOS.cs | CSharp | SHA256 | 571b68362c6d5aa5eaabe027d52cf92ed893ff2b6d490466d4d21e49780b8516 | 20558 | 2085 | 9 | 50-40630 |
| 372 | frmPOS.Designer.cs | CSharp | SHA256 | a34d37d68cf896f7be03d2855c8036477e6cb0fe4657ebdc9761d64c27e46d2f | 14290 | 2 | 1 | 13-17094 |
| 373 | frmPOSRecord.cs | CSharp | SHA256 | 05fb607cf90bf854b28fe44970314e67302196f93c6ca68115aecff30c417a47 | 219 | 83 | 1 | 27-886 |
| 374 | frmPOSRecord.Designer.cs | CSharp | SHA256 | 16fc1b5ae637d090cffb2cc118b71dad99b0f0145deaa1e4dd77176f5718116a | 471 | 2 | 1 | 13-507 |
| 375 | frmPOSReport_CRViewer.cs | CSharp | SHA256 | f7b93ec7f5604d4eac0802ed4a12f711d5e5db37f9562706bba12d8a65f2308c | 909 | 27 | 1 | 34-1253 |
| 376 | frmPOSReport_CRViewer.Designer.cs | CSharp | SHA256 | 49c13d8deb04d6adb62a11d053c20ba71d43a89ab1fe02c500825bdedf4d51f8 | 151 | 2 | 1 | 13-172 |
| 377 | frmPOSReport_CRViewer1.cs | CSharp | SHA256 | 4860c1bd1154bb01db4aee54781331a506b6b77994143dba587354b2c6c6461b | 969 | 27 | 1 | 34-1361 |
| 378 | frmPOSReport_CRViewer1.Designer.cs | CSharp | SHA256 | e2d65ec83015a7b63ff923e4defc7d2f3c38de7e781c115b911a0a010203b684 | 151 | 2 | 1 | 13-172 |
| 379 | frmPOSReport.cs | CSharp | SHA256 | 6300fcfd6750c0ed42be394ddf887243d71cc6572df79869ba8caede26f678d5 | 1775 | 105 | 1 | 32-2810 |
| 380 | frmPOSReport.Designer.cs | CSharp | SHA256 | 558c0ce2c90f869ef1c919aeb3e81b5fb0d4253bf39fae0e876ce8a5978147f0 | 886 | 2 | 1 | 13-1067 |
| 381 | frmPrinterStatus.cs | CSharp | SHA256 | 5a802715c4aef697f57d321363d938f8f123ba31162082cceb87b02de9261587 | 111 | 15 | 1 | 26-245 |
| 382 | frmPrinterStatus.Designer.cs | CSharp | SHA256 | 8a29cbf01e958d9992c25c96e3bded7d88aa7f4c070f12a3bee71daf854fb606 | 68 | 2 | 1 | 13-89 |
| 383 | frmPrintLoyaltyCard.cs | CSharp | SHA256 | 5406aad19f87350b37e4108c72e74cb02227b6a67b8b30c18f4bc2e64a781ea4 | 235 | 38 | 1 | 27-591 |
| 384 | frmPrintLoyaltyCard.Designer.cs | CSharp | SHA256 | a9c769aed28d22ee471bb012a02ae76033f19b994e7a51406258f4fcd2c4ef6e | 143 | 2 | 1 | 13-170 |
| 385 | frmPrintVIPMemberCard.cs | CSharp | SHA256 | f86cb1a46cf4fb35c55371abef4fa9ec673459dc34901e17f4363d06cf7fc490 | 235 | 38 | 1 | 27-591 |
| 386 | frmPrintVIPMemberCard.Designer.cs | CSharp | SHA256 | 7285c971a244835760ab8d6c9faa62f3e24918c022c671dc98e64075d23cfa88 | 143 | 2 | 1 | 13-170 |
| 387 | frmProduct.cs | CSharp | SHA256 | dc209cc7ff01f0bd3cd841347d6a2cf61fa58400f053a541a3395805aa41acf6 | 852 | 139 | 1 | 29-2112 |
| 388 | frmProduct.Designer.cs | CSharp | SHA256 | 22ed7bca9eb9f93bc4a3ec2f8174ccd2299952096d74e22d390ba41d3681e3e4 | 798 | 2 | 1 | 13-852 |
| 389 | frmProductRecord.cs | CSharp | SHA256 | 32968a2ca404c77fbf3bf4a961c0baa7f94a36bc160a3760407df52f1d3a2b04 | 259 | 69 | 1 | 27-875 |
| 390 | frmProductRecord.Designer.cs | CSharp | SHA256 | b1f5972e5c645418b14fc34d73829ea030c0317ab67cb289ce57860740936f4a | 382 | 2 | 1 | 13-414 |
| 391 | frmPromotion.cs | CSharp | SHA256 | 7ee01c4526afab6b4fbb66fb3e768a061795daac8aa44560743c44615f2c244b | 500 | 100 | 1 | 28-1387 |
| 392 | frmPromotion.Designer.cs | CSharp | SHA256 | d4b7d0413e42cdff46dfd5639232c9857697b5b616ee208909627e0a850dc5aa | 562 | 2 | 1 | 13-601 |
| 393 | frmPurchaseEntry.cs | CSharp | SHA256 | e9a76ea57edc927ece1da536a5852ad5176f1a183e7c00a93fdaf742662a75c3 | 1169 | 229 | 1 | 32-3110 |
| 394 | frmPurchaseEntry.Designer.cs | CSharp | SHA256 | 2b78d7cfb75f70b6274e7e6d63b5ec2cdedaf1019e56f3f91f767ac6aae2bd36 | 1249 | 2 | 1 | 13-1294 |
| 395 | frmPurchaseOrder.cs | CSharp | SHA256 | 99f2dd57b67b16957fa13070e6a9a48fce486799a5ef26a756a832b1d5f361a2 | 930 | 185 | 1 | 29-2467 |
| 396 | frmPurchaseOrder.Designer.cs | CSharp | SHA256 | 1c5a7dd0c0956240c67c2e358fae07f026073963f4502ea5beff48440325e007 | 1020 | 2 | 1 | 13-1052 |
| 397 | frmPurchaseOrderRecord.cs | CSharp | SHA256 | bd6e6218cefa3991e41174f897660de4000e2c2f62c7f38beb51dfe3b34ed8e2 | 281 | 80 | 1 | 27-984 |
| 398 | frmPurchaseOrderRecord.Designer.cs | CSharp | SHA256 | e3dd3dfc5dc7066b1d471813a87fa4f02e941c1de1365c25bfe72d6f228f3aa0 | 433 | 2 | 1 | 13-471 |
| 399 | frmPurchaseRecord.cs | CSharp | SHA256 | 835e018ef014ae4fca94fd12fa548dcf1030e6dc8939b7d32973ddb6f489b60f | 291 | 92 | 1 | 27-1099 |
| 400 | frmPurchaseRecord.Designer.cs | CSharp | SHA256 | 6442cd3026d5de0d26cb749e635a0187e0a12c15fe21d1da6bffbe16c01e604d | 468 | 2 | 1 | 13-512 |
| 401 | frmRawMaterialsCategory.cs | CSharp | SHA256 | 0e062be0ddb43956c3a26b6f3a1ff1363a9afbe18dc383e8b4076babd3fb0eee | 264 | 46 | 1 | 26-684 |
| 402 | frmRawMaterialsCategory.Designer.cs | CSharp | SHA256 | 2eded4ccf24ed1206fc4c11e4fad2f6def0ab03e6bab22e73fd54acdf2285bc7 | 322 | 2 | 1 | 13-346 |
| 403 | frmRawMaterialsUsed.cs | CSharp | SHA256 | 41b5ba0b0f546820fefb0101222c73ae1848961d3fd80da331bade25d2fee46e | 138 | 41 | 1 | 26-482 |
| 404 | frmRawMaterialsUsed.Designer.cs | CSharp | SHA256 | 157ef05b8979cd108090dece53d2faf5285d3b512a5aa460e55a2e80729a51f5 | 268 | 2 | 1 | 13-295 |
| 405 | frmRecipe.cs | CSharp | SHA256 | a0e8b5b6a1ca97f8be7030395f2ec5824242972a302fb298c644b8cf702c0ed3 | 795 | 129 | 1 | 29-1944 |
| 406 | frmRecipe.Designer.cs | CSharp | SHA256 | 14b7be69b4ff4cc286c0743a48d8b6b614dc0033c13901a3b6e1ff0220495647 | 681 | 2 | 1 | 13-709 |
| 407 | frmRecipeRecord.cs | CSharp | SHA256 | a1f0845991d43b1bea41bdab8c2d8ac5ed2487402bf1607ea20c677d27976933 | 168 | 40 | 1 | 26-527 |
| 408 | frmRecipeRecord.Designer.cs | CSharp | SHA256 | ada4ab3edf9efe2a60304013ceb28d368b3cea0b38fcac84b7859c5f9fb5349b | 234 | 2 | 1 | 13-263 |
| 409 | frmRecoveryPIN.cs | CSharp | SHA256 | c466734681041ad8a2136ec1b58e914e5f4cf52246db8a87f44cd21f6cc74fbe | 183 | 30 | 1 | 28-454 |
| 410 | frmRecoveryPIN.Designer.cs | CSharp | SHA256 | 76902d9d51ddbe3004df73b4e0b0e943a31b3fa269532543bb685ef56dd146d0 | 143 | 2 | 1 | 13-164 |
| 411 | frmRefundMoney.cs | CSharp | SHA256 | 6a9d34056911703cc9757eba087bd6de931c7db35a43491435261d3de7154409 | 355 | 80 | 1 | 27-1042 |
| 412 | frmRefundMoney.Designer.cs | CSharp | SHA256 | cb4197961f8033f5b7f90733d561635be6ec732e917705ae088e3a555109f9e3 | 475 | 2 | 1 | 13-501 |
| 413 | frmRefundMoneyRecord.cs | CSharp | SHA256 | 2529764ea11374ec2cc2b895827173dafd3aa5567f13caaf4f14d520707878d8 | 213 | 59 | 1 | 28-716 |
| 414 | frmRefundMoneyRecord.Designer.cs | CSharp | SHA256 | 4e247ed7ea929279bb07986bfe0fc4605840d4adb8af26b99ab1bfebf0d414c0 | 360 | 2 | 1 | 13-388 |
| 415 | frmRegistration.cs | CSharp | SHA256 | e6622cc8a148edffe593200deefbdcdc6c249ba132658b07d413320058f547b0 | 727 | 124 | 1 | 29-1886 |
| 416 | frmRegistration.Designer.cs | CSharp | SHA256 | 18f9656889bab5cba8f747b9aae1cd985d3e8fdeb95820c26cbf1612c8cd37ab | 664 | 2 | 1 | 13-713 |
| 417 | frmReport.cs | CSharp | SHA256 | bbf5a485454da93bd3e6172fcefe47ad49d2c5848a3d82e2d46985d5018b72ba | 96 | 15 | 1 | 29-262 |
| 418 | frmReport.Designer.cs | CSharp | SHA256 | c828378b280ad08431c3b717d591270124c721d36766595032dcdb27700465fd | 86 | 2 | 1 | 13-107 |
| 419 | frmRestaurantMaster.cs | CSharp | SHA256 | e33df26a77cef08203abf34db1927489d7d4bb2cce0480295d271233c898f22d | 582 | 149 | 1 | 31-1852 |
| 420 | frmRestaurantMaster.Designer.cs | CSharp | SHA256 | d0bf92575a45cd16bf248293b552e7b2aa7e83c16a384fdc11e3d57fa32a623b | 810 | 2 | 1 | 13-850 |
| 421 | frmRestaurantPOSEBRecord_Unpaid.cs | CSharp | SHA256 | c2812fa1c2de66eb3f785169f5afbe9bb91c77bf12aeab29edb771ea898614fe | 384 | 98 | 1 | 28-1224 |
| 422 | frmRestaurantPOSEBRecord_Unpaid.Designer.cs | CSharp | SHA256 | dbe94f52f7131fc622e334c677f41a217b78143368dd462227af7f4386df4377 | 492 | 2 | 1 | 13-536 |
| 423 | frmRestaurantPOSEBRecord.cs | CSharp | SHA256 | c7270e29de0675b320e4319142b5bd453d6f907be273fbbe82e6e1f10abeee3d | 361 | 102 | 1 | 28-1219 |
| 424 | frmRestaurantPOSEBRecord.Designer.cs | CSharp | SHA256 | 25df1228b95967ce5078af57c52c068504820afcaf5993919ebd1b496d3d697f | 511 | 2 | 1 | 13-556 |
| 425 | frmRestaurantPOSHDRecord.cs | CSharp | SHA256 | f739391bc7cf9cb6a894ab4ba42e381efef38a6ef36c3cc3f9ae2a96efc1faa6 | 358 | 104 | 1 | 28-1232 |
| 426 | frmRestaurantPOSHDRecord.Designer.cs | CSharp | SHA256 | fc5f67d3345fc3f1f999a24c9fe3cb4d219f32567fe290126578cd4be126d30b | 514 | 2 | 1 | 13-560 |
| 427 | frmRestaurantPOSHDRecord1.cs | CSharp | SHA256 | ab8d3815d29340cc1ab9cf0c16cbb93f78b8650817709f1393b89493c643f471 | 344 | 102 | 1 | 28-1193 |
| 428 | frmRestaurantPOSHDRecord1.Designer.cs | CSharp | SHA256 | c3f94923cd1c3c376a5e6f4d1e75d40ca742cc24f2b4b3473c30235771baf50e | 497 | 2 | 1 | 13-543 |
| 429 | frmRestaurantPOSKOTFinalBillRecord_Unpaid.cs | CSharp | SHA256 | 2080886ce6f0194cbbff7a9c59842b8c1cd8065c05859539ead42ad8c01fd0d7 | 373 | 105 | 1 | 29-1269 |
| 430 | frmRestaurantPOSKOTFinalBillRecord_Unpaid.Designer.cs | CSharp | SHA256 | d75127219e3d975f76c88665d7e994a5faea3c8f67ece6dd053071d290b0e3d1 | 486 | 2 | 1 | 13-536 |
| 431 | frmRestaurantPOSKOTFinalBillRecord.cs | CSharp | SHA256 | 429ffa17a6c44f2f6f3c6442bd3b331fcfab467b7b22697427740b5a35a8e6ea | 356 | 106 | 1 | 28-1244 |
| 432 | frmRestaurantPOSKOTFinalBillRecord.Designer.cs | CSharp | SHA256 | d2d48e9bfb92e9d9a8a0eff953afeb3a6c6114da6766aad5586fa0abe89db04a | 519 | 2 | 1 | 13-566 |
| 433 | frmRestaurantPOSKOTRecord.cs | CSharp | SHA256 | 1ea6c7384380a00be4810c8492a508a1ac558885cccc23703607e64adfe45ca3 | 284 | 73 | 1 | 28-909 |
| 434 | frmRestaurantPOSKOTRecord.Designer.cs | CSharp | SHA256 | 0a3f9a15ffd7af9ee945371efa48e1f4261581b87fceb1b56cd4021996b3700a | 398 | 2 | 1 | 13-432 |
| 435 | frmRestaurantPOSTARecord_Unpaid.cs | CSharp | SHA256 | 2d87ae3d278eea5c1a4a10c6073c2b834d16c3faf524742c3192394206f0bdcf | 391 | 104 | 1 | 28-1279 |
| 436 | frmRestaurantPOSTARecord_Unpaid.Designer.cs | CSharp | SHA256 | 93b1efa957de94b608037e28fcf6490c68f21183713f67b0b07f2018c3df762a | 509 | 2 | 1 | 13-556 |
| 437 | frmRestaurantPOSTARecord.cs | CSharp | SHA256 | ca6f7024909c7ebf7f14e6f6d3a9e7c000a9d6956c9b65f576e081a499176dbc | 359 | 106 | 1 | 28-1245 |
| 438 | frmRestaurantPOSTARecord.Designer.cs | CSharp | SHA256 | 387da227182a36df458e5260caa329b3a02dae0cfbb678eb0d8511418163b305 | 524 | 2 | 1 | 13-571 |
| 439 | frmSecondaryDisplay.cs | CSharp | SHA256 | 32ee8478f0c06f1b59e4617c64c048c32530b2b8c0190fe6e7e43567a3daf471 | 162 | 49 | 1 | 27-554 |
| 440 | frmSecondaryDisplay.Designer.cs | CSharp | SHA256 | f991f23a280891abbc408d9a304a357265002bbf02fb70ebd42c4fcd458feba7 | 324 | 2 | 1 | 13-351 |
| 441 | frmSendBroadcastSMS.cs | CSharp | SHA256 | 7ab866b3d2db1e72746a32e7b1ae1b45c994d4a5d58187282dda9961422d856d | 149 | 32 | 1 | 27-439 |
| 442 | frmSendBroadcastSMS.Designer.cs | CSharp | SHA256 | db79c1a53193b44a57a6ee9f856d0ea99db77988af40e81584dc9baa39fc6395 | 140 | 2 | 1 | 13-166 |
| 443 | frmSendEmail.cs | CSharp | SHA256 | cb56b6d06e3080735e58928995be4c9daaa2a3d79823abcb9894fe9927cc58f7 | 199 | 43 | 1 | 28-590 |
| 444 | frmSendEmail.Designer.cs | CSharp | SHA256 | 0bcc120e17b552db546199774265ed933cc3787c266d903353b79d1eb0363228 | 206 | 2 | 1 | 13-231 |
| 445 | frmSetDiscount.cs | CSharp | SHA256 | 3b4ec5d105bb29c4fcd5b0eb11906175f6ca4c22ec89580518cd2cfb04c80a4f | 353 | 56 | 1 | 26-891 |
| 446 | frmSetDiscount.Designer.cs | CSharp | SHA256 | 03003645a8a9cd46f65d89b9dd3349cb9296575923409d472a078cf3e860844e | 490 | 2 | 1 | 13-661 |
| 447 | frmSetNOP.cs | CSharp | SHA256 | f84813a9bbb0af38797bb970e9b64c8588b16799ea9308bd9a9dd45a2bdac952 | 321 | 55 | 1 | 26-824 |
| 448 | frmSetNOP.Designer.cs | CSharp | SHA256 | 9ee0b1809baaa04a31770485d72764b5aa357dcc88a9a423b48813c1cf10e032 | 462 | 2 | 1 | 13-623 |
| 449 | frmSettings.cs | CSharp | SHA256 | eeeeae6d2b958849bf39e0d5cf8266e416e182af2f000cf94729cd17480b2c85 | 278 | 68 | 1 | 26-816 |
| 450 | frmSettings.Designer.cs | CSharp | SHA256 | 6ebbf56d6b4b491ab5188181ac88f207242ed7fea0e239e607563ba044e5c1a0 | 756 | 2 | 1 | 13-977 |
| 451 | frmSMSSetting.cs | CSharp | SHA256 | 2592e7f20ecfccc0036b62e66f8796d885bb86fc88c910dc2409bd7e36163815 | 272 | 52 | 1 | 26-761 |
| 452 | frmSMSSetting.Designer.cs | CSharp | SHA256 | c7f84d81b3cf82cb306984ccc6051a4f130c3c1aeea619ae035ca38638ea6064 | 317 | 2 | 1 | 13-344 |
| 453 | frmSoftwareLicenceRenewal.cs | CSharp | SHA256 | 1a3c2100ece0e042b06e435910c9f82c1c77cbf317bd8e5fefc9fc6b27ab13fe | 182 | 43 | 1 | 30-550 |
| 454 | frmSoftwareLicenceRenewal.Designer.cs | CSharp | SHA256 | 2187cb0f45442af0ed7a3c01b166ede15550fcee1f54cb039dd532c5d86a70b9 | 275 | 2 | 1 | 13-300 |
| 455 | frmSplash.cs | CSharp | SHA256 | deb078afe43ac80760a65ea1593a6e1b875bd087283c4bce46623015ecb26416 | 113 | 26 | 1 | 27-352 |
| 456 | frmSplash.Designer.cs | CSharp | SHA256 | 022b84369625640fb317d8a0ecc19ab0c46888f4a402efaf12f3b7f077371f13 | 155 | 2 | 1 | 13-176 |
| 457 | frmSqlServerSetting.cs | CSharp | SHA256 | 5cda9c1daf37fe74f047de2dce107c539970b4f1f61f9d3bf94e49067ef6ea92 | 456 | 66 | 1 | 32-1166 |
| 458 | frmSqlServerSetting.Designer.cs | CSharp | SHA256 | 0a1f4bffed9e72c282b4bf3c11c235daf527c6d9e401899869eb94c2ada674df | 407 | 2 | 1 | 13-486 |
| 459 | frmStock_Store.cs | CSharp | SHA256 | 6a095d4dc2e722ccdffcd10622b0b7a50e836a5b47d498edf2a9bf55e226e997 | 451 | 82 | 1 | 29-1142 |
| 460 | frmStock_Store.Designer.cs | CSharp | SHA256 | 4c90f1d7646082cfc9ca44d0245d94b5995288bf08f3f0c4e0b40dce40146948 | 483 | 2 | 1 | 13-508 |
| 461 | frmStock_StoreRecord.cs | CSharp | SHA256 | 23bffa0594b6b36cf3199291106b2cf20a8f62515436fcf5ef2813f59a8175c0 | 223 | 50 | 1 | 27-648 |
| 462 | frmStock_StoreRecord.Designer.cs | CSharp | SHA256 | fc08813b109100110a2d3176176f0046a9c22c42324c98aee5c805a6d30f995b | 307 | 2 | 1 | 13-333 |
| 463 | frmStockAdjustment_MI_Record.cs | CSharp | SHA256 | 660eedca7e1f65a5bbd396d301b625d75ddd28e93b70722b6a5626281a9898cb | 227 | 63 | 1 | 28-767 |
| 464 | frmStockAdjustment_MI_Record.Designer.cs | CSharp | SHA256 | a00890e37def3a83e2387fdf99de6d1aab424e14500915223565d5a16ac2f298 | 387 | 2 | 1 | 13-416 |
| 465 | frmStockAdjustment_MI.cs | CSharp | SHA256 | 602c491607c8c84342ef7c183e87128b84a6425f2e7fb1e623efdafd5dd1cdb8 | 430 | 78 | 1 | 27-1134 |
| 466 | frmStockAdjustment_MI.Designer.cs | CSharp | SHA256 | 30102139f8ab97ad20650fa0383efe2f415bcc4a4f7e403783fb2199e0b41c4a | 448 | 2 | 1 | 13-469 |
| 467 | frmStockAdjustment_Store_Record.cs | CSharp | SHA256 | afb77e31b3f896f747ca27c2ade73172c719399c2ad08b6b0a088aadbcfa3ca2 | 235 | 68 | 1 | 28-825 |
| 468 | frmStockAdjustment_Store_Record.Designer.cs | CSharp | SHA256 | 02c0821c6baded200b06629cf6354dbb24317a325c4a185278636e87782a7ed7 | 400 | 2 | 1 | 13-432 |
| 469 | frmStockAdjustment_Store.cs | CSharp | SHA256 | 9d211af087759f5b0ef0491cb5f697931a8407ed43299eb053a0e2b9d09d34fd | 457 | 84 | 1 | 28-1217 |
| 470 | frmStockAdjustment_Store.Designer.cs | CSharp | SHA256 | 5511aa1c9cfdebb9280b1a4f935a4bc7ecfb7ef9f985732a6957b6467601c943 | 480 | 2 | 1 | 13-501 |
| 471 | frmStockAdjustment_Warehouse_Record.cs | CSharp | SHA256 | ec59f8e9b0da154485d57447e99c8ed3ee365e598275c2b330206371df239f6b | 240 | 70 | 1 | 27-847 |
| 472 | frmStockAdjustment_Warehouse_Record.Designer.cs | CSharp | SHA256 | df57247f3aa894da11cb6dd1940f70cf3fb8e6d896ff157bbcb19b1ec546d9fe | 404 | 2 | 1 | 13-437 |
| 473 | frmStockAdjustment_Warehouse.cs | CSharp | SHA256 | 4e3dc2cd9e5c1b28d3d0e5247907116833d13dd8e22cbacfd9c41b4f34edc859 | 517 | 90 | 1 | 28-1328 |
| 474 | frmStockAdjustment_Warehouse.Designer.cs | CSharp | SHA256 | 4e426fd274062900efc84f950a30b8870114e6fccd970f84cb56afdc95d5f4c3 | 507 | 2 | 1 | 13-528 |
| 475 | frmStockAdjustment.cs | CSharp | SHA256 | 6814cae4117dd2eca6eda3febc53dc58d2e734f74d00eac231586f49c32ef742 | 76 | 17 | 1 | 24-221 |
| 476 | frmStockAdjustment.Designer.cs | CSharp | SHA256 | 05f439a4a67310ad20bd33e338495e2daf4241432ee66eba391d6e1987bc768c | 109 | 2 | 1 | 13-130 |
| 477 | frmStockIn_RM.cs | CSharp | SHA256 | c9dadce5a096d8eae3c3ee8ee703d42c9136ea107bdf7d85328e63c622de3d28 | 130 | 35 | 1 | 25-436 |
| 478 | frmStockIn_RM.Designer.cs | CSharp | SHA256 | 7245afdbe181dc02191fd0c940660216dabee7e6e9df41174046e2f99575087f | 229 | 2 | 1 | 13-256 |
| 479 | frmStockIn_StoreRecord.cs | CSharp | SHA256 | 361998016f611c3163b4c6fa55ed56dd08c7d975cfc00f4eb8dd57376635fa05 | 127 | 33 | 1 | 25-418 |
| 480 | frmStockIn_StoreRecord.Designer.cs | CSharp | SHA256 | be63088aab435d87a1af4e9fc4bc545c2fd651c30e7cd10b408a40dfb4135184 | 215 | 2 | 1 | 13-242 |
| 481 | frmStockInRecord.cs | CSharp | SHA256 | ad3f1e5402ce620dfa2492b138a28a98bcb1e1bc68f878b0999d39f75cf5f217 | 202 | 55 | 1 | 26-698 |
| 482 | frmStockInRecord.Designer.cs | CSharp | SHA256 | c0a7a120216406e4056fc293276e3b7e91f0c74e23047e2f26cfb34a72aad7b2 | 332 | 2 | 1 | 13-361 |
| 483 | frmStockOUT_RM.cs | CSharp | SHA256 | 3ad3b2500012db2228b73a3f321fbca565c5a6809220353144a6e01c2affebcd | 120 | 31 | 1 | 25-384 |
| 484 | frmStockOUT_RM.Designer.cs | CSharp | SHA256 | 9b535b068f989c3e236f988a358169085529fc3fe3e99732321d51c781f466ff | 215 | 2 | 1 | 13-240 |
| 485 | frmStockOUT_StoreRecord.cs | CSharp | SHA256 | 155d9afd4099bba3b92bdd169e9977bad30e5662fb98941d881df713e48b6eb8 | 117 | 29 | 1 | 25-366 |
| 486 | frmStockOUT_StoreRecord.Designer.cs | CSharp | SHA256 | 954d2ea20f20494d76b58cfa5db6be8619bedc7304e3fd8c26541b6a74a5a68d | 201 | 2 | 1 | 13-226 |
| 487 | frmStockOUTRecord.cs | CSharp | SHA256 | 220aad1a8262077d37c81d19e351d7fd86a32485b9fe5f271a5be35b914afea7 | 145 | 36 | 1 | 25-459 |
| 488 | frmStockOUTRecord.Designer.cs | CSharp | SHA256 | 80746bfe838ee0efd50a0eb59fdc99f0f420e154cb9564a0530433b609ac0859 | 231 | 2 | 1 | 13-257 |
| 489 | frmStockTransfer.cs | CSharp | SHA256 | 8e4cacdf94eed3d34365a99b653f369841c07993e91ec06a555425cd20b9eb93 | 733 | 133 | 1 | 30-1855 |
| 490 | frmStockTransfer.Designer.cs | CSharp | SHA256 | 8d1e24a8ba9f21c75cc9c360760fb0781adde8e0ea9b60ea3cb61b2d7b847361 | 729 | 2 | 1 | 13-765 |
| 491 | frmStockTransferRecord.cs | CSharp | SHA256 | a22f9d27653b27d5f0a63976c3611c55632ab99b4917daf6912518e873f7faf6 | 271 | 56 | 1 | 27-752 |
| 492 | frmStockTransferRecord.Designer.cs | CSharp | SHA256 | e64d94576d06e874f4337094e23e998d7581ed78a43db21b66922bda65715ea7 | 335 | 2 | 1 | 13-361 |
| 493 | frmSupplier.cs | CSharp | SHA256 | 4383f87938d814615d80acc6ae9b3970d8e940b9109d512e51fcd4237841ab45 | 598 | 129 | 1 | 28-1686 |
| 494 | frmSupplier.Designer.cs | CSharp | SHA256 | 29b75ee0f902898eebf0eafed24d6724a56657598ff0e34b335410a0b6c9f987 | 755 | 2 | 1 | 13-780 |
| 495 | frmSupplierRecord.cs | CSharp | SHA256 | ebb4e679dcc666141c28601d98c1ec7cd3ac5ead6b6ac79bb7f2296747170bd7 | 352 | 96 | 1 | 27-1220 |
| 496 | frmSupplierRecord.Designer.cs | CSharp | SHA256 | 71bf1a2665e9b6802d473b7f8c8047e0fafa395cabe626f1337723c47d67ec5c | 443 | 2 | 1 | 13-487 |
| 497 | frmSystemInfo.cs | CSharp | SHA256 | d7ddac063026b47a3cdcef8f423315ea6508a45bac4c6d27830aa1a971f0bd6c | 437 | 132 | 1 | 28-1442 |
| 498 | frmSystemInfo.Designer.cs | CSharp | SHA256 | f7da275209f846b09fd9cad5035fd82f65d443464c6bd37ece5019da8756acd4 | 803 | 2 | 1 | 13-832 |
| 499 | frmTable.cs | CSharp | SHA256 | d9980f71d773f2041bcc2347353516ac9e8805bc56bc535f3cfa9c8ff75bdb57 | 432 | 65 | 1 | 26-1046 |
| 500 | frmTable.Designer.cs | CSharp | SHA256 | baadcd0a5052d432ea0ba4f7c5930b3deffddbf998cebf99a9d2b9e09de78324 | 401 | 2 | 1 | 13-440 |
| 501 | frmTableLayout.cs | CSharp | SHA256 | 6c6f26341a04b12cf7b7645bbab838d508159ed4e5197ed5a5e64ce5de55b2c5 | 222 | 18 | 1 | 27-434 |
| 502 | frmTableLayout.Designer.cs | CSharp | SHA256 | 3c5861ea5844a42957f6962e5769b191dd8eaf7d3d459b7e1b328820995b8a51 | 84 | 2 | 1 | 13-105 |
| 503 | frmTableLayoutSettings.cs | CSharp | SHA256 | 747d09dd6a931582deed1da73100cddd86c746fde566e978ceb604a60cd439e9 | 327 | 41 | 1 | 30-679 |
| 504 | frmTableLayoutSettings.Designer.cs | CSharp | SHA256 | 1fe2e1161fbdbd6f3dbae52f401702e22cbfbe9ed658aa5c0ff6587ab694b40d | 196 | 2 | 1 | 13-225 |
| 505 | frmTableList.cs | CSharp | SHA256 | 371b6bfc087ea934b617598ab0cfaf571bc6fd7b4b819aa2d8d518c1ad772b78 | 257 | 22 | 1 | 27-512 |
| 506 | frmTableList.Designer.cs | CSharp | SHA256 | bb0c0156fc6b1adedbc6d5ffff28350fff62ec6a66c0691f5e6b4012c9a9888b | 102 | 2 | 1 | 13-123 |
| 507 | frmTableMapping_Waiter.cs | CSharp | SHA256 | 0cdf1ec40443d5d760e268e037ecf16bf1b708392a97cd3d6858f1bc736c6ef6 | 381 | 67 | 1 | 27-964 |
| 508 | frmTableMapping_Waiter.Designer.cs | CSharp | SHA256 | 58cfb29d36b5834a8aaf4cff035b0b9d6d0699d3c206bcf974ab8c2a7494d53f | 394 | 2 | 1 | 13-420 |
| 509 | frmTableReservation.cs | CSharp | SHA256 | 50b57348cb2ddc4d69328d0dc1c56a60da411bfdda40ab5f04603b6a16006b99 | 586 | 149 | 1 | 27-1872 |
| 510 | frmTableReservation.Designer.cs | CSharp | SHA256 | 1ca555759fe110ad28c0c6acc9f3c91a73fbf3da9aa8e308aace222cf18482b7 | 832 | 2 | 1 | 13-869 |
| 511 | frmTablesExportImport.cs | CSharp | SHA256 | 1276074e7f0ddfa0f1af1f8f0dffce1a482d61a4ffb91d900ca4ffe3d6e9ce59 | 195 | 37 | 1 | 29-514 |
| 512 | frmTablesExportImport.Designer.cs | CSharp | SHA256 | 9c1d962147d75ff67f159afe29baf0de1d202429bd2122d889f5b1007ae37f1d | 267 | 2 | 1 | 13-292 |
| 513 | frmTerminalSetting.cs | CSharp | SHA256 | 09565b648da4daaf5785f6bead6d3ddd54e50d194d7f8f6690eb6a01905d92a1 | 618 | 145 | 1 | 31-1911 |
| 514 | frmTerminalSetting.Designer.cs | CSharp | SHA256 | a3ef4069561b7239cbb591cfc16ae05692d4410de0d9abd39876d65ff628b183 | 834 | 2 | 1 | 13-878 |
| 515 | frmTestDualDisplay.cs | CSharp | SHA256 | 9ef7d8207ceb18b6e9d03450abfcca4bcbaa8f298cd29dbf028e964fad19f8e4 | 30 | 5 | 1 | 23-82 |
| 516 | frmTestDualDisplay.Designer.cs | CSharp | SHA256 | f6c6a8842ad6753790dae17ddf39cc91e395fe8ebdfd2fbafa58fcfdb5491939 | 37 | 2 | 1 | 13-58 |
| 517 | frmToppingsList.cs | CSharp | SHA256 | 5b37a791bd0b66742244fed84f89e365227ad578a7792a75275039f080fb485e | 376 | 62 | 1 | 30-932 |
| 518 | frmToppingsList.Designer.cs | CSharp | SHA256 | fff1f3aeda984704d069b18fee475ebb87afa1ec6e9784e6fd97d3149995f4fc | 356 | 2 | 1 | 13-420 |
| 519 | frmToppingsList1.cs | CSharp | SHA256 | 5f86bcce2b81af5f8bb428b339e921994a3a724adc5eab465e99dbd65d9248e6 | 373 | 62 | 1 | 29-924 |
| 520 | frmToppingsList1.Designer.cs | CSharp | SHA256 | 2c030069ea362ec0cd64b325b8f2bc7b6533207f60159ad06771266e3939731a | 351 | 2 | 1 | 13-415 |
| 521 | frmUnit.cs | CSharp | SHA256 | f5cd8ab8d3034f70b362f304c70225aea3e26b472f392d3b4d93ac850d37d7fe | 254 | 47 | 1 | 26-685 |
| 522 | frmUnit.Designer.cs | CSharp | SHA256 | 00d3cb024fd80d643758012d7d0b1473f0516f7315fd44e06ead5a7683977985 | 328 | 2 | 1 | 13-352 |
| 523 | frmUserRights.cs | CSharp | SHA256 | bf021b7fd83e5142844ac4756b6152e1a2d4edfc2fc470ee72f414eef48c405e | 661 | 81 | 1 | 29-1385 |
| 524 | frmUserRights.Designer.cs | CSharp | SHA256 | 4d469cbe0ed021ebe41246a30869cdefbd8ad94552d43f911d94357f64ca44a2 | 329 | 2 | 1 | 13-358 |
| 525 | frmVIPMemberCard.cs | CSharp | SHA256 | 64730ee000cedf3a7dede963b5df18988883cea7540ec43942a84be946d7d447 | 98 | 23 | 1 | 24-289 |
| 526 | frmVIPMemberCard.Designer.cs | CSharp | SHA256 | f961c95287b64833412a123da62e0dbfe7d4b36c02bde6521a7725c72a85405c | 159 | 2 | 1 | 13-180 |
| 527 | frmVoucher.cs | CSharp | SHA256 | 4720622c13d6e7b52b28fd4dc21c9d3b6a8b0d01c853930418aeaf5c73cda6c8 | 550 | 110 | 1 | 30-1462 |
| 528 | frmVoucher.Designer.cs | CSharp | SHA256 | b8c192b93aa7913d8c4835e6014172401ebffbc4f00b6d71508109c825d4f400 | 641 | 2 | 1 | 13-671 |
| 529 | frmVoucherRecord.cs | CSharp | SHA256 | fa0e8682bb1a33ee6cf23fb1e9cdcd0c6db59c40f060736e2a4bc8ff4213da29 | 239 | 49 | 1 | 29-644 |
| 530 | frmVoucherRecord.Designer.cs | CSharp | SHA256 | f434bfd14bb50ab996702c0519c1bbc6358a8b5da23197b2032d63d0fe33a086 | 317 | 2 | 1 | 13-338 |
| 531 | frmWaiterList.cs | CSharp | SHA256 | 771e5bee7a1046d03a977bba91c92d5df853649347a741884a92752155420c62 | 87 | 17 | 1 | 26-230 |
| 532 | frmWaiterList.Designer.cs | CSharp | SHA256 | 28420ed28273452f1a9ec685db9676da6a309608c2c16621f07931dd6f81c88e | 83 | 2 | 1 | 13-104 |
| 533 | frmWalletList.cs | CSharp | SHA256 | acee0838738ea2eee9f5d54b75efd878f669ecd8332f7cd02f6c4237bb188670 | 326 | 42 | 1 | 32-758 |
| 534 | frmWalletList.Designer.cs | CSharp | SHA256 | 88afd510fed73be6cc5bdb07e05d1c14566f6d8484d315ec5efc696040fdbbc7 | 206 | 2 | 1 | 13-227 |
| 535 | frmWalletType.cs | CSharp | SHA256 | 74ab241e8c3db524e868ab71c30ba2aee0c8389353c724e3bccc13b390b285e5 | 275 | 45 | 1 | 25-682 |
| 536 | frmWalletType.Designer.cs | CSharp | SHA256 | e580d3864de0de3653f0ad7a30455f6fbb264a655087f835f7a2a21308ce619e | 295 | 2 | 1 | 13-319 |
| 537 | frmWarehouse.cs | CSharp | SHA256 | e6e54cfe6c11acd619e153e3f15099cc679d8c3de05a821c4066a2fbc2f0fb5e | 419 | 75 | 1 | 28-1103 |
| 538 | frmWarehouse.Designer.cs | CSharp | SHA256 | d04dabcd193b56655a58123756cc64695edb2428104f648d68f1ab2000b66209 | 429 | 2 | 1 | 13-456 |
| 539 | frmWarehouseType.cs | CSharp | SHA256 | aef613106c00ef7c3d01798e9a40c1f1a659479db567399336f3d916d01ff19f | 256 | 45 | 1 | 26-672 |
| 540 | frmWarehouseType.Designer.cs | CSharp | SHA256 | 181ac793890783c5601f2f21b6fe6d3976448d724c06ed35828cb7279764a669 | 294 | 2 | 1 | 13-318 |
| 541 | frmWorkPeriod_Del.cs | CSharp | SHA256 | a1db784e619a546b5a0e37eec94a0242f5eedfb260fa73c91513209a63bab63b | 146 | 36 | 1 | 27-461 |
| 542 | frmWorkPeriod_Del.Designer.cs | CSharp | SHA256 | 258713d85e27101421c379f4af1979fed61826801032caff2238a1ea283b964d | 230 | 2 | 1 | 13-257 |
| 543 | frmWorkPeriod.cs | CSharp | SHA256 | 015d7ccbd965c48f15968a427a2d375023632d5b3ec8017560ec4771421cbfeb | 1030 | 55 | 1 | 30-1696 |
| 544 | frmWorkPeriod.Designer.cs | CSharp | SHA256 | 2981beb4c9751c83c33be56dc84790cb9c48d78a81b1b67d66f21dd0ee989c7e | 336 | 2 | 1 | 13-361 |
| 545 | frmWorkPeriodReport.cs | CSharp | SHA256 | 6415cdadbc5baf74def2886ec84e84b266f0a52b2e4e6c9d8182456925b31a94 | 568 | 43 | 1 | 29-979 |
| 546 | frmWorkPeriodReport.Designer.cs | CSharp | SHA256 | f4f3a2d5d596d0ce3dab69443ec0293986bb4b57309f09a25ac4f46b3ba5d315 | 242 | 2 | 1 | 13-263 |
| 547 | frmWPReport_CRViewer.cs | CSharp | SHA256 | 2d4d2067da0b6f5ab1d45ad90bf4d1db68ea623d09113124eca59e21edd58815 | 803 | 28 | 1 | 34-1166 |
| 548 | frmWPReport_CRViewer.Designer.cs | CSharp | SHA256 | 0491ab83b9fbb24ba40ed436cad3bf9883450be3f97fc1d12fb06782237fac64 | 151 | 2 | 1 | 13-172 |
| 549 | ModCashDrawer.cs | CSharp | SHA256 | 7d223423983edc814ed80ac020863d61f27ffb5d7ab09c3cf7a380486381aabb | 25 | 2 | 1 | 18-81 |
| 550 | ModFunc.cs | CSharp | SHA256 | a44468f7f0801e39fe1d0217a921fbd1e17f16f8a0375bc80ef3f3f5faeb05d9 | 684 | 60 | 1 | 38-1097 |
| 551 | modPanelExtension.cs | CSharp | SHA256 | 04ed9f8ec3c818b3f18b73113a884f30f0c94dcaefeba3ffcceaf6cca4513876 | 12 | 2 | 1 | 14-37 |
| 552 | My\InternalXmlHelper.cs | CSharp | SHA256 | 1a132ce50ee57b40d6e239646aab7375c52023286d3b3787f4006e9b01c4d61b | 116 | 15 | 2 | 21-277 |
| 553 | My\MyApplication.cs | CSharp | SHA256 | fe9e5680b8f6ec3e2ef352ef270ebde1b455e78a71633a25f429d8a31a91b4ae | 35 | 5 | 1 | 21-87 |
| 554 | My\MyComputer.cs | CSharp | SHA256 | 55f88a29984e5968019084fac5e75d62d190384ad7e0e2da77eb2cc878ba8292 | 2 | 1 | 1 | 17-19 |
| 555 | My\MyProject.cs | CSharp | SHA256 | 986962ba99a2a9081580af9b03a9341d459aca6ebe68efb51689fe5fd64a95e2 | 1695 | 492 | 4 | 31-6854 |
| 556 | My\MySettings.cs | CSharp | SHA256 | 36d063fd717a2f7ce258a6f24f5c40f58e802b573a3db3cbfc4a7095c8691ea5 | 2 | 1 | 1 | 17-19 |
| 557 | My\MySettings.Designer.cs | CSharp | SHA256 | 1ef2dc2d402bc50e9eb8ee58cd1aa734131518a055343f19319d855611bb4194 | 18 | 4 | 1 | 24-74 |
| 558 | My\MySettingsProperty.cs | CSharp | SHA256 | b71b51b31f30061c6c680584f6566a554861201ebf712c5b6e77510f3fd5b514 | 1 | 1 | 1 | 24-24 |
| 559 | My\Resources\Resources.cs | CSharp | SHA256 | c6e225c8658f85b00dd8d844c1cbdf0ded0371cdb2dcfedb2eb3d9753fb145d1 | 125 | 122 | 1 | 32-1423 |
| 560 | MyButton.cs | CSharp | SHA256 | 7cdcbb833090f0c3c2af88e0e062fde63b57799395aa7d12ad0b8a4379774582 | 28 | 3 | 1 | 16-61 |
| 561 | MyGlobal.cs | CSharp | SHA256 | 29fb75aa0c66f5405f4d093f9ce65b51c6e2130bde338b0442e78bc7ec2af26f | 3 | 2 | 1 | 11-16 |
| 562 | RPOS_DBDataSet.cs | CSharp | SHA256 | 3f7ccaf539e2a630564675155db94dba443785972974b31fbbefe71a774a6563 | 18630 | 4433 | 202 | 41-63858 |
| 563 | RPOS_DBDataSet1.cs | CSharp | SHA256 | 2f1b2f997198e8d970d0f21591507478042200372f9d3a0d4a3a5b77e0496b67 | 30418 | 7267 | 313 | 40-104920 |
| 564 | RPOS_DBDataSet1TableAdapters\ActivationTableAdapter.cs | CSharp | SHA256 | 6ed8980fdcc37728c334762f32566552b0f572ad7bca0f8d0654c415970f03bb | 181 | 26 | 1 | 31-479 |
| 565 | RPOS_DBDataSet1TableAdapters\BankAccountLedgerTableAdapter.cs | CSharp | SHA256 | acac98729695178aea3d545b2dc3e188f6c19c8fabf7f4e4b033cab14ee3c6f7 | 309 | 26 | 1 | 31-687 |
| 566 | RPOS_DBDataSet1TableAdapters\BankAccountRegistrationTableAdapter.cs | CSharp | SHA256 | 94c1332913078df13a83aea9d40914a40d7cd26dee640c4f6e2970b28b851526 | 346 | 26 | 1 | 34-751 |
| 567 | RPOS_DBDataSet1TableAdapters\BankBranchTableAdapter.cs | CSharp | SHA256 | 89749d880cdf1a8e049458933d65b27a6547acd8de2ed85e5f83645f5ff37e8a | 301 | 26 | 1 | 31-671 |
| 568 | RPOS_DBDataSet1TableAdapters\BankTableAdapter.cs | CSharp | SHA256 | c1802dc6d1faac90494ec7c8c9866e80b8c9ffca7b982e505194e0b98e2a500e | 157 | 26 | 1 | 34-450 |
| 569 | RPOS_DBDataSet1TableAdapters\CategoryTableAdapter.cs | CSharp | SHA256 | 4093a7bcdc40ba9b3e32b88c51ef6cb03946028b3197802fa5dcdc857b7b4c16 | 297 | 26 | 1 | 34-670 |
| 570 | RPOS_DBDataSet1TableAdapters\ClockINTableAdapter.cs | CSharp | SHA256 | 43050b31efcebe4584d500171a9bc05231c3bc96f2ae8476dbb73dbd0e0e0736 | 201 | 26 | 1 | 31-515 |
| 571 | RPOS_DBDataSet1TableAdapters\ClockOUTTableAdapter.cs | CSharp | SHA256 | 2c7d93d17fc7c40046106575abcbe4837a386a7268831d912e683f1a075fe85e | 201 | 26 | 1 | 34-518 |
| 572 | RPOS_DBDataSet1TableAdapters\CMISettingTableAdapter.cs | CSharp | SHA256 | 9bdd0f3990018068af3c3bb68be96642cc6f34421be01d3da732c9e0d48e3528 | 228 | 26 | 1 | 31-558 |
| 573 | RPOS_DBDataSet1TableAdapters\CreditCustomerLedgerTableAdapter.cs | CSharp | SHA256 | 4377086ab119e20c49ab82d9b3a51734b883a4f5ee768c0434719c9a156c781a | 309 | 26 | 1 | 31-687 |
| 574 | RPOS_DBDataSet1TableAdapters\CreditCustomerPaymentTableAdapter.cs | CSharp | SHA256 | 6b1a809829a4bce2641a2e31f3a6d826974bed8ca68555b00a967fc67d5a6728 | 284 | 26 | 1 | 34-633 |
| 575 | RPOS_DBDataSet1TableAdapters\CreditCustomerTableAdapter.cs | CSharp | SHA256 | 379eaae9731e4b098f84b47c6bfce4ad4be276334f787c0e039a5a252e0483d5 | 339 | 26 | 1 | 34-736 |
| 576 | RPOS_DBDataSet1TableAdapters\CurrencyTableAdapter.cs | CSharp | SHA256 | b3ac607c6781cd3c44f92e388b3d242952026415c040b6f99b92da20080722bf | 183 | 26 | 1 | 31-481 |
| 577 | RPOS_DBDataSet1TableAdapters\DeletedInvoices_JoinTableAdapter.cs | CSharp | SHA256 | b4a7c5eb6cde4d42993598f74dfaaeb8d05209456565afa9cf5014544862e6b0 | 239 | 26 | 1 | 31-577 |
| 578 | RPOS_DBDataSet1TableAdapters\DeletedInvoicesTableAdapter.cs | CSharp | SHA256 | 1a2d795161199ccaee2a30c270dfbeafb5b4223d64362b1d1ba39bdeef427631 | 390 | 26 | 1 | 34-819 |
| 579 | RPOS_DBDataSet1TableAdapters\DishTableAdapter.cs | CSharp | SHA256 | b174155d0c29c32c60b1089563e49f8de4224e7d6748a1f7e2c165f09f2a4ab5 | 438 | 26 | 1 | 34-899 |
| 580 | RPOS_DBDataSet1TableAdapters\EmailSettingTableAdapter.cs | CSharp | SHA256 | cfc6eacd6fb3adee61b2f60f17da341647c25099450a1fe6b8a425accfd014d8 | 275 | 26 | 1 | 31-613 |
| 581 | RPOS_DBDataSet1TableAdapters\EmployeeRegistrationTableAdapter.cs | CSharp | SHA256 | 7583bc2e0c0473017e186baaa8ab826e95a154a005e1d66d9658b076928cc753 | 296 | 26 | 1 | 34-649 |
| 582 | RPOS_DBDataSet1TableAdapters\ExpenseTableAdapter.cs | CSharp | SHA256 | 47af4647494e6df0b1318cb88e6157583deca051b203262e7188494997e81d92 | 174 | 26 | 1 | 31-472 |
| 583 | RPOS_DBDataSet1TableAdapters\ExpenseTypeTableAdapter.cs | CSharp | SHA256 | 94b03ecbe0acb4f2f64ab2f3d2703a48a0a7e98897edd19e4814eac9972d61b0 | 157 | 26 | 1 | 34-450 |
| 584 | RPOS_DBDataSet1TableAdapters\FundDepositTableAdapter.cs | CSharp | SHA256 | 59c4400a688e25fca53281ab8184e4507795e2261fcaa3ff5b034f8eb8425e41 | 284 | 26 | 1 | 31-646 |
| 585 | RPOS_DBDataSet1TableAdapters\FundTransferTableAdapter.cs | CSharp | SHA256 | 01954631b856fc1fedb872349365d3a846536629805b5f8644d355e625979412 | 311 | 26 | 1 | 34-692 |
| 586 | RPOS_DBDataSet1TableAdapters\GiftCardTableAdapter.cs | CSharp | SHA256 | dab7b31b8413ec394a06b168fd3023e171a053d1e9392d1b83924e1344e9ec51 | 238 | 26 | 1 | 31-576 |
| 587 | RPOS_DBDataSet1TableAdapters\GridGroupingTableAdapter.cs | CSharp | SHA256 | 86ff6d0798c46e77ad3ad6e0cf4ace4efa69a0af6c29ffe52f53dcb599c7815f | 175 | 26 | 1 | 34-468 |
| 588 | RPOS_DBDataSet1TableAdapters\HDCustomerTableAdapter.cs | CSharp | SHA256 | 9b402a0d5d8c6f133bcfa4911bcb2140b5a1850973e2783dee1349fdf8baa61a | 212 | 26 | 1 | 31-534 |
| 589 | RPOS_DBDataSet1TableAdapters\HoldBillTableAdapter.cs | CSharp | SHA256 | 6505dbd9b0c8da969460783b6420eb62512c8438294371a2c97079535880928b | 373 | 26 | 1 | 34-794 |
| 590 | RPOS_DBDataSet1TableAdapters\HoldItemsTableAdapter.cs | CSharp | SHA256 | 846231b6dc5a752b05d1884176b9780750ee6177315b904ec9c6d754da86d6d6 | 585 | 26 | 1 | 31-1131 |
| 591 | RPOS_DBDataSet1TableAdapters\HotelTableAdapter.cs | CSharp | SHA256 | 240d3f570434a259ccb951f81c31bf6a3a5ba5cc2e258d125905284aeec36d93 | 547 | 26 | 1 | 34-1072 |
| 592 | RPOS_DBDataSet1TableAdapters\JournalTableAdapter.cs | CSharp | SHA256 | c66c20367d22f558aad1f9c1af9fd83fa323002d88f02ed39b66d5e79b67ec04 | 268 | 26 | 1 | 31-622 |
| 593 | RPOS_DBDataSet1TableAdapters\KitchenTableAdapter.cs | CSharp | SHA256 | 4c0d3612f9884d082d8111c86f8698dc1aea1ab5ef8b74435fab07609fa1342d | 191 | 26 | 1 | 34-500 |
| 594 | RPOS_DBDataSet1TableAdapters\LedgerBookTableAdapter.cs | CSharp | SHA256 | b570121aac7b595edd488c874cea5d06e2534b67040d2b1e1c050138b51b3e44 | 363 | 26 | 1 | 31-773 |
| 595 | RPOS_DBDataSet1TableAdapters\LogsTableAdapter.cs | CSharp | SHA256 | d07aa0d916360729e0319f23dd762a67cbb441371bdad38c2e0260299a103a1d | 190 | 26 | 1 | 34-491 |
| 596 | RPOS_DBDataSet1TableAdapters\LoyaltyMemberLedgerBookTableAdapter.cs | CSharp | SHA256 | d55e336d268fcb064c1172e27d9dd957a19a7cabee344b3232cb41beaeb6ed6d | 235 | 26 | 1 | 34-552 |
| 597 | RPOS_DBDataSet1TableAdapters\LoyaltyMemberTableAdapter.cs | CSharp | SHA256 | c1a5bf5a0278e4f3a254660156cdddffd0c39645f4a37c9edd222052c18dd10c | 295 | 26 | 1 | 31-665 |
| 598 | RPOS_DBDataSet1TableAdapters\LoyaltySettingTableAdapter.cs | CSharp | SHA256 | 68b146e5aa7962779e9b2a35ab7058254628b988d2ac09df00cb539b4617198d | 211 | 26 | 1 | 31-533 |
| 599 | RPOS_DBDataSet1TableAdapters\MemberLedgerTableAdapter.cs | CSharp | SHA256 | b587f6651dccd9666d08ab320398a4a71300d44dd098127c4d8f8f612def5534 | 311 | 26 | 1 | 31-689 |
| 600 | RPOS_DBDataSet1TableAdapters\MemberTableAdapter.cs | CSharp | SHA256 | d977cc326edcac6ed627ba8eb6890917be860fd41d737ae7d3de896846be2acd | 268 | 26 | 1 | 34-625 |
| 601 | RPOS_DBDataSet1TableAdapters\ModifiersTableAdapter.cs | CSharp | SHA256 | c7c52c1f7121257b8bee1743da51b51132bd7a70b1544ca70a412e8fe057745c | 257 | 26 | 1 | 34-606 |
| 602 | RPOS_DBDataSet1TableAdapters\MpesaSettingTableAdapter.cs | CSharp | SHA256 | f9f2eeaedc5584126fefc62c1e74631cfe40590cee2a92f2760b77c2700e8c3a | 309 | 26 | 1 | 31-687 |
| 603 | RPOS_DBDataSet1TableAdapters\NotesMasterTableAdapter.cs | CSharp | SHA256 | 1169c2c872f9866055cab932ca4e61aa2175ea7e8d6dc0f4e26f2ddfece3a9cc | 164 | 26 | 1 | 34-457 |
| 604 | RPOS_DBDataSet1TableAdapters\OtherSettingTableAdapter.cs | CSharp | SHA256 | 9a1eba804f98da0f609f911320327c1026cec7abf5f42c874d0a797b0d74c644 | 687 | 26 | 1 | 31-1289 |
| 605 | RPOS_DBDataSet1TableAdapters\Payment_WithdrawTableAdapter.cs | CSharp | SHA256 | 1e20b76b6fa65e46c9d5533985098903f8f9a37e8e8cdd211af3d3e73f6f11e1 | 338 | 26 | 1 | 31-732 |
| 606 | RPOS_DBDataSet1TableAdapters\PaymentTableAdapter.cs | CSharp | SHA256 | f1371428c23055997b3a9ffecb0eada8d7c3824bf8ecf8f1913dc21a5e4a95c2 | 284 | 26 | 1 | 34-633 |
| 607 | RPOS_DBDataSet1TableAdapters\Payroll_MBTableAdapter.cs | CSharp | SHA256 | 38bd38c3e4d7a1f540d3f397ee0d2c753883efe7fa17efe2f67e492b734b880a | 608 | 26 | 1 | 31-1162 |
| 608 | RPOS_DBDataSet1TableAdapters\PayrollTableAdapter.cs | CSharp | SHA256 | 42b81a53ecbb99c015234323e8bbe9acf90de8580c41729731f755ceae88fc35 | 608 | 26 | 1 | 34-1165 |
| 609 | RPOS_DBDataSet1TableAdapters\PizzaMasterTableAdapter.cs | CSharp | SHA256 | fb7264b3a1c532fb91b923afca305938c15559a0ceeffd4368a038a3949d7553 | 295 | 26 | 1 | 34-668 |
| 610 | RPOS_DBDataSet1TableAdapters\PizzaModifierTableAdapter.cs | CSharp | SHA256 | 9004c28b583ff0dd30f269cf8e35e108d36f4da07d4bb765f746938fc6174170 | 257 | 26 | 1 | 31-603 |
| 611 | RPOS_DBDataSet1TableAdapters\PizzaSizeTableAdapter.cs | CSharp | SHA256 | 3cd80f2bce2cf0d3f0d9e6ce01d243a836a3d51b9756b0c2040fbd061726aa23 | 157 | 26 | 1 | 34-450 |
| 612 | RPOS_DBDataSet1TableAdapters\PizzaToppingTableAdapter.cs | CSharp | SHA256 | eef17915093ae8a24b4dd9a7853da5e095109018cf0929c280008103ac0b6d9b | 284 | 26 | 1 | 31-646 |
| 613 | RPOS_DBDataSet1TableAdapters\PosGrouping1TableAdapter.cs | CSharp | SHA256 | f37b0f98e4cefe48430b36825da4d50be41ec7d3d2a7dc431467227ca1ae428a | 601 | 26 | 1 | 31-1155 |
| 614 | RPOS_DBDataSet1TableAdapters\PosGroupingTableAdapter.cs | CSharp | SHA256 | ed129bbee9f5d515faf5644c2ecde2d5d6de2ebefe2f035fe2b8b0802da422a7 | 574 | 26 | 1 | 34-1115 |
| 615 | RPOS_DBDataSet1TableAdapters\PosPrinterSettingTableAdapter.cs | CSharp | SHA256 | cecd3de8d5e71aa3092cdf7d9c15deb7649f00fb700870fce3fa4e70995eed07 | 563 | 26 | 1 | 34-1096 |
| 616 | RPOS_DBDataSet1TableAdapters\Product_OpeningStockTableAdapter.cs | CSharp | SHA256 | fe864d3929997d2eea5e2edd35da9f17b53cccd98e7ecfeac9368b5614603492 | 236 | 26 | 1 | 34-561 |
| 617 | RPOS_DBDataSet1TableAdapters\ProductTableAdapter.cs | CSharp | SHA256 | 0acb15310d65a4497e011d0540ed6af47976d096fc383f4d00d238e7de7e4809 | 293 | 26 | 1 | 31-647 |
| 618 | RPOS_DBDataSet1TableAdapters\PromotionTableAdapter.cs | CSharp | SHA256 | a12ae98d3f9029d75ac069946a87c8f200298d8911f07d793edbbd94bd5a5c3d | 309 | 26 | 1 | 31-687 |
| 619 | RPOS_DBDataSet1TableAdapters\Purchase_JoinTableAdapter.cs | CSharp | SHA256 | c609daf48d02c9983ee1fb642503215701275b66b15b759ac1601a5b695fefc4 | 263 | 26 | 1 | 31-585 |
| 620 | RPOS_DBDataSet1TableAdapters\PurchaseOrder_JoinTableAdapter.cs | CSharp | SHA256 | f8514aa6c27e36c81460223c2a1fcc9be5f5353be472acb75b0f304b86c57fdd | 228 | 26 | 1 | 31-542 |
| 621 | RPOS_DBDataSet1TableAdapters\PurchaseOrderTableAdapter.cs | CSharp | SHA256 | 4d69b004cd0cf7c3bccc023332ad3b11edfe87f1cceee4cb26773ed06f9eb1fb | 366 | 26 | 1 | 34-779 |
| 622 | RPOS_DBDataSet1TableAdapters\PurchaseTableAdapter.cs | CSharp | SHA256 | 84469c67485a767ac223e1ac0ecb6b00f78b3b69c637b8b03d5a49114d31b77f | 365 | 26 | 1 | 34-706 |
| 623 | RPOS_DBDataSet1TableAdapters\R_TableTableAdapter.cs | CSharp | SHA256 | e06543009ec81835f623d948845f215d3cdbb67e4072eda7239c533c8360cc3c | 237 | 26 | 1 | 34-570 |
| 624 | RPOS_DBDataSet1TableAdapters\Recipe_JoinTableAdapter.cs | CSharp | SHA256 | 45deb849ef7c3d24576373287bf420dc186391acbea8e1b15f6de54cfe996b53 | 246 | 26 | 1 | 34-579 |
| 625 | RPOS_DBDataSet1TableAdapters\RecipeTableAdapter.cs | CSharp | SHA256 | b2fa24403404c82bf29e82005f6875f807adf278deda6e0032dfb2e94a70945d | 203 | 26 | 1 | 31-509 |
| 626 | RPOS_DBDataSet1TableAdapters\RegistrationTableAdapter.cs | CSharp | SHA256 | 98a305319bde2a25e1a6e1df11010701027ddeb554332c59bed9bca093fe495d | 406 | 26 | 1 | 31-832 |
| 627 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoEBTableAdapter.cs | CSharp | SHA256 | fb258ed3e0d8e7561a3701ce2b61b88c4e1b9dbbecbd5b6f7f2a4b6e994db9b4 | 753 | 26 | 1 | 34-1390 |
| 628 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoHDTableAdapter.cs | CSharp | SHA256 | d89ec1ceb12d20ebf4c7e318eb385ef7bcf9dd67dcbe60c015d534a924861e0b | 743 | 26 | 1 | 31-1369 |
| 629 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoKOTTableAdapter.cs | CSharp | SHA256 | 53ddf0ae4bb2461b16f58abf5d904283257d385016723e67536ea8850e03288b | 905 | 26 | 1 | 34-1638 |
| 630 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoTATableAdapter.cs | CSharp | SHA256 | 32278ebf3f370071b8fbe35d4cca911b90ed71dfccaec627c0d6be617c45390a | 807 | 26 | 1 | 31-1473 |
| 631 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillEBTableAdapter.cs | CSharp | SHA256 | 29fe7dffca76b7893c0e0280dee319a694865200e6c36faf569599b3a572108d | 628 | 26 | 1 | 34-1201 |
| 632 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillHDTableAdapter.cs | CSharp | SHA256 | ef94c81d440d15c3983e74b5e9e209c550af7a693022d909adc758d05ceb31ac | 601 | 26 | 1 | 31-1155 |
| 633 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillKOTTableAdapter.cs | CSharp | SHA256 | 7051e38018ecf2eb262fd905b4b12e0865ae81fbf6b156719abedad42e09f7cd | 617 | 26 | 1 | 34-1182 |
| 634 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillTATableAdapter.cs | CSharp | SHA256 | f518a9cb15d901f2258809012cbe43ea29e40cbfd7ea6ce51a553622584d4a77 | 628 | 26 | 1 | 31-1198 |
| 635 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductKOTTableAdapter.cs | CSharp | SHA256 | 8d69fee97bb4a424e6c8b63350785a5db60915b4832cab6f5f1a735028632286 | 628 | 26 | 1 | 34-1201 |
| 636 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderInfoKOTTableAdapter.cs | CSharp | SHA256 | ab945bd3a7dcb8d7e44b125233e999fb8431da09c767209737a4b2ce8bd22974 | 402 | 26 | 1 | 31-828 |
| 637 | RPOS_DBDataSet1TableAdapters\RM_Used_JoinTableAdapter.cs | CSharp | SHA256 | b064397522e19e3363e363230258ac7ac70291f78fe39ce4410d6a43a139383c | 228 | 26 | 1 | 31-558 |
| 638 | RPOS_DBDataSet1TableAdapters\RM_UsedTableAdapter.cs | CSharp | SHA256 | 9f5f26acd510e64ba54daf2d8a041e24b0a8f6a697e1612e79125b08a63bb3ec | 203 | 26 | 1 | 34-520 |
| 639 | RPOS_DBDataSet1TableAdapters\RMCategoryTableAdapter.cs | CSharp | SHA256 | 2aa4d432a3b61066fa3254f6bcf1eb2b85470e8160216607c497efff3bff20af | 157 | 26 | 1 | 34-450 |
| 640 | RPOS_DBDataSet1TableAdapters\SMSSettingTableAdapter.cs | CSharp | SHA256 | 85cdce785706802a51a67c33cd08665d773f597e4b6fec21b0d9ab80ad411b9e | 190 | 26 | 1 | 31-492 |
| 641 | RPOS_DBDataSet1TableAdapters\Stock_Store_JoinTableAdapter.cs | CSharp | SHA256 | 1cf51971108c048653c46c0c56bf73a870b7e22f781372a9fcfaf28c37a89c51 | 182 | 26 | 1 | 31-472 |
| 642 | RPOS_DBDataSet1TableAdapters\Stock_StoreTableAdapter.cs | CSharp | SHA256 | 4ec90bfb52136f49997e934e3ffca9a5d72624cd3b70e2bbe2baa35eb616be3e | 175 | 26 | 1 | 34-468 |
| 643 | RPOS_DBDataSet1TableAdapters\StockAdjustment_MITableAdapter.cs | CSharp | SHA256 | 81ac8d35b49dbfdd71b8f92e7000236476132c5e2b814cd945e40c5033b13554 | 284 | 26 | 1 | 34-649 |
| 644 | RPOS_DBDataSet1TableAdapters\StockAdjustment_StoreTableAdapter.cs | CSharp | SHA256 | 120f295f3943917961982eceaaf2444acd19417df5f97e64ee0dea766aa17fa7 | 284 | 26 | 1 | 31-646 |
| 645 | RPOS_DBDataSet1TableAdapters\StockAdjustment_WarehouseTableAdapter.cs | CSharp | SHA256 | 2d7ce6bb46ac1618987b218525cf8ba83534aa3c61f88b11c9885d7d4ea11ae3 | 311 | 26 | 1 | 34-692 |
| 646 | RPOS_DBDataSet1TableAdapters\StockTransfer_JoinTableAdapter.cs | CSharp | SHA256 | 8cf6a68886d8afd236e98d0be2fa25e12d183a631f54c523f6f6680df65d833c | 218 | 26 | 1 | 34-527 |
| 647 | RPOS_DBDataSet1TableAdapters\StockTransferTableAdapter.cs | CSharp | SHA256 | 70d2b3f10ff294b4b3b96f0b13bf093ff8a29de928f159684b53e99683f6781c | 175 | 26 | 1 | 31-465 |
| 648 | RPOS_DBDataSet1TableAdapters\SupplierLedgerBookTableAdapter.cs | CSharp | SHA256 | 26c4c04c6257898fe7cbcc5c3ae616000c04fcd7079bbfbc20e78c850032be53 | 252 | 26 | 1 | 34-577 |
| 649 | RPOS_DBDataSet1TableAdapters\SupplierTableAdapter.cs | CSharp | SHA256 | 9cb90c89a1b2cc02e96b65980557edd8261fa5a8b3558c770e7de02eabce197d | 663 | 26 | 1 | 31-1249 |
| 650 | RPOS_DBDataSet1TableAdapters\TableAdapterManager.cs | CSharp | SHA256 | 72398ff9b547b52b8e1114bbf2fe02b90b30b393f40e310d985a9644fa03c761 | 3829 | 229 | 2 | 33-8482 |
| 651 | RPOS_DBDataSet1TableAdapters\TableLayoutTableAdapter.cs | CSharp | SHA256 | 68cc65072b883c3c501adbd7c7eb1da3f7b580db4be3e764905af252843e0168 | 336 | 26 | 1 | 31-730 |
| 652 | RPOS_DBDataSet1TableAdapters\TableMappingTableAdapter.cs | CSharp | SHA256 | e7b1de5db515d1b35b6f34636ba0d5f455edb50366c13872267e8443867d34c2 | 201 | 26 | 1 | 34-518 |
| 653 | RPOS_DBDataSet1TableAdapters\TableReservationTableAdapter.cs | CSharp | SHA256 | 3aca84ad3a96e7b6696fb972ee75badec3f471c6b61e89c597f47b8376af003f | 365 | 26 | 1 | 31-775 |
| 654 | RPOS_DBDataSet1TableAdapters\tblOrderTableAdapter.cs | CSharp | SHA256 | 8af4dc9f150a3dc3f7842ba242b5f6f87a001d3f37d9c0543be886007a7965d4 | 183 | 26 | 1 | 34-484 |
| 655 | RPOS_DBDataSet1TableAdapters\Temp_Stock_RMTableAdapter.cs | CSharp | SHA256 | 0176ff78f347ba647b0c8f6a14eea932ef9e7829f24c149ace0d1d78d7b8409b | 165 | 26 | 1 | 34-450 |
| 656 | RPOS_DBDataSet1TableAdapters\Temp_Stock_StoreTableAdapter.cs | CSharp | SHA256 | b2ea94e5c0de82c42500fff68c3d42d5135bbe2d9c6c3bcb12c07bd79ea6fd11 | 173 | 26 | 1 | 31-463 |
| 657 | RPOS_DBDataSet1TableAdapters\Temp_StockTableAdapter.cs | CSharp | SHA256 | 1d7178b28ec28c13efd7d8f096cafa605a9727b4a87cbe47d6ba93f1b5f56e0f | 236 | 26 | 1 | 31-558 |
| 658 | RPOS_DBDataSet1TableAdapters\TempRestaurantPOS_BillingInfoKOTTableAdapter.cs | CSharp | SHA256 | 2cfca87176b38dcdeb98b8c51fabb4ed8350a4970f2a6fa95729bfa562048003 | 781 | 26 | 1 | 34-1442 |
| 659 | RPOS_DBDataSet1TableAdapters\TempRestaurantPOS_OrderedProductBillKOTTableAdapter.cs | CSharp | SHA256 | 57a5970f523c1bed7864b7a20b3885553c4b87eb3a8bf68764a2ac71d97fa65a | 617 | 26 | 1 | 31-1179 |
| 660 | RPOS_DBDataSet1TableAdapters\UnitMasterTableAdapter.cs | CSharp | SHA256 | 159dfa98cdb360b99e115d66cc375a56b8d27f424ce3dd71bdfe5891ba4877f1 | 157 | 26 | 1 | 34-450 |
| 661 | RPOS_DBDataSet1TableAdapters\UserRightsTableAdapter.cs | CSharp | SHA256 | 20c6c0c91150d66ad9005bbcbfcab9d145d835f1f8e9672544df56f6ad7d2450 | 309 | 26 | 1 | 31-687 |
| 662 | RPOS_DBDataSet1TableAdapters\Voucher_OtherDetailsTableAdapter.cs | CSharp | SHA256 | 6f0ea6ebab7931702b041a3cfc98d68ae63de191967c4cc46b3336c4a9cfd495 | 193 | 26 | 1 | 31-491 |
| 663 | RPOS_DBDataSet1TableAdapters\VoucherTableAdapter.cs | CSharp | SHA256 | 06595c183ea30dec993db07948a48434bc8320eeea214e5877d1e5a154aed920 | 239 | 26 | 1 | 34-564 |
| 664 | RPOS_DBDataSet1TableAdapters\WalletTableAdapter.cs | CSharp | SHA256 | bd3a81aedf5a45f2bd230dc2b8efb2d3079456060a9ca08c53baca7363dc980b | 157 | 26 | 1 | 34-450 |
| 665 | RPOS_DBDataSet1TableAdapters\WarehouseTableAdapter.cs | CSharp | SHA256 | 61409a8c8a90932c1eac8a52ff154e40c902aa9de4a1cb504147741fefd311a3 | 208 | 26 | 1 | 31-522 |
| 666 | RPOS_DBDataSet1TableAdapters\WarehouseTypeTableAdapter.cs | CSharp | SHA256 | cabe7f83365eb9a62a1481ec30b30e74c606bee0d5e30b6b7717a54a1d08b379 | 157 | 26 | 1 | 34-450 |
| 667 | RPOS_DBDataSet1TableAdapters\WorkPeriodEndTableAdapter.cs | CSharp | SHA256 | 635d0f64dd4503a4eb5e38d5bf3f5db6f3273e5765b592b1d4d659f101289940 | 158 | 26 | 1 | 31-440 |
| 668 | RPOS_DBDataSet1TableAdapters\WorkPeriodStartTableAdapter.cs | CSharp | SHA256 | fb5ad78f5f240c70b89f94dd1092c8a9ffaa6d51c8dae91ccdd6da677ccfe627 | 173 | 26 | 1 | 34-466 |
| 669 | RPOS_DBDataSetTableAdapters\ActivationTableAdapter.cs | CSharp | SHA256 | b0456a45cbedc2a36817a33590c8f00095e708b07ca66a7ccb46108b5da8b25a | 167 | 24 | 1 | 30-442 |
| 670 | RPOS_DBDataSetTableAdapters\CategoryTableAdapter.cs | CSharp | SHA256 | d1b6566cf5789bbb11203bc0b8cf263fa0d152a452ef2317dd58fc30832609cd | 283 | 24 | 1 | 33-633 |
| 671 | RPOS_DBDataSetTableAdapters\CreditCustomerLedgerTableAdapter.cs | CSharp | SHA256 | 14a21891b34acfbc6ca5bbe58398931f4201cd46d40c3b385a062107dacb7093 | 295 | 24 | 1 | 33-653 |
| 672 | RPOS_DBDataSetTableAdapters\CreditCustomerPaymentTableAdapter.cs | CSharp | SHA256 | 81c9fdc2e6121ef6259cae59fd99fd0f5ba6f933f0dc9fc3e52d0b46b87b6f93 | 270 | 24 | 1 | 30-593 |
| 673 | RPOS_DBDataSetTableAdapters\CreditCustomerTableAdapter.cs | CSharp | SHA256 | db3cdff618c2ebb8835fbc17e1b5259efaedd89583a7bb1d17a77de9ce04b8ff | 325 | 24 | 1 | 30-696 |
| 674 | RPOS_DBDataSetTableAdapters\CurrencyTableAdapter.cs | CSharp | SHA256 | 906297e7511bc4aa4818f17458413b6ea5c23ae5177501474fe8faa19313e3cb | 169 | 24 | 1 | 33-447 |
| 675 | RPOS_DBDataSetTableAdapters\DishTableAdapter.cs | CSharp | SHA256 | 61b94956717c3414c310292da7cc94060d33350684161331948e17192d35f428 | 359 | 24 | 1 | 30-754 |
| 676 | RPOS_DBDataSetTableAdapters\EmailSettingTableAdapter.cs | CSharp | SHA256 | ad8573c4c1d8f3d407f570ff076b58202a605b5309f19d272fdae8f0c578e444 | 261 | 24 | 1 | 33-579 |
| 677 | RPOS_DBDataSetTableAdapters\EmployeeRegistrationTableAdapter.cs | CSharp | SHA256 | 7155f65258fae2ae32b57a633fefd9c5315caafd09f8d3ddc5809df4b30de8f4 | 282 | 24 | 1 | 30-609 |
| 678 | RPOS_DBDataSetTableAdapters\ExpenseTableAdapter.cs | CSharp | SHA256 | 294b37c02872252603de32580c982cb00ae59d00f2092e069ddbe0a0ff8ada4c | 160 | 24 | 1 | 33-438 |
| 679 | RPOS_DBDataSetTableAdapters\ExpenseTypeTableAdapter.cs | CSharp | SHA256 | 2073b68d4348b8ffef826051c0f809e8a0aaf47c4ffeb49b8cc8c59ce8821976 | 143 | 24 | 1 | 30-410 |
| 680 | RPOS_DBDataSetTableAdapters\GridGroupingTableAdapter.cs | CSharp | SHA256 | 21b3eca428b666baf65a229a36cf29209a98abc4ab56aaea6ea737d182d00849 | 161 | 24 | 1 | 33-431 |
| 681 | RPOS_DBDataSetTableAdapters\HDCustomerTableAdapter.cs | CSharp | SHA256 | 9995c15637f46028ee11b6d50abbc44ac6a28e61aeaba2f145da15507fabcc96 | 198 | 24 | 1 | 30-497 |
| 682 | RPOS_DBDataSetTableAdapters\HotelTableAdapter.cs | CSharp | SHA256 | b1b6f1259a91a96122e00cfd9472ab7345a14730ef3184abfe68654704a2a2d9 | 468 | 24 | 1 | 33-930 |
| 683 | RPOS_DBDataSetTableAdapters\KitchenTableAdapter.cs | CSharp | SHA256 | 9fd662a508a2df16f98d1dd225f734abc067222e58af6c6faf313ab028c00b4b | 177 | 24 | 1 | 30-460 |
| 684 | RPOS_DBDataSetTableAdapters\LedgerBookTableAdapter.cs | CSharp | SHA256 | e40311870249622e888d0bc5e5adb6330632a46dd1efe293d94bf52869cc17a3 | 238 | 24 | 1 | 33-540 |
| 685 | RPOS_DBDataSetTableAdapters\LogsTableAdapter.cs | CSharp | SHA256 | ea67c1403ddef5c9d474c041d13f483b4c592d314c4482f961d90dddcbe28794 | 176 | 24 | 1 | 30-451 |
| 686 | RPOS_DBDataSetTableAdapters\LoyaltyMemberLedgerBookTableAdapter.cs | CSharp | SHA256 | a213b7f6f3d5dad96aca72f107ae1454a3f09c2402fa0a40ac99bb9842172bd1 | 221 | 24 | 1 | 30-512 |
| 687 | RPOS_DBDataSetTableAdapters\LoyaltyMemberTableAdapter.cs | CSharp | SHA256 | ad29345449aa3b5486138ae18dc5949ecf525e86d1a96b9c523b84505b18c01e | 254 | 24 | 1 | 33-588 |
| 688 | RPOS_DBDataSetTableAdapters\LoyaltySettingTableAdapter.cs | CSharp | SHA256 | 10d0581c76d8906d21a5ed6e53a2753f5dd65cfee0cf48e35033f76506a7a4cd | 197 | 24 | 1 | 33-499 |
| 689 | RPOS_DBDataSetTableAdapters\MemberLedgerTableAdapter.cs | CSharp | SHA256 | b20dcf44cb8c93188ae19237e583ddbd7d11c6d2a4b3db979e14196589141988 | 297 | 24 | 1 | 33-655 |
| 690 | RPOS_DBDataSetTableAdapters\MemberTableAdapter.cs | CSharp | SHA256 | 6cc87e7a8e9500bbe377a3de7a9e91a309af411b00353a16ae698fa8308925d6 | 254 | 24 | 1 | 30-585 |
| 691 | RPOS_DBDataSetTableAdapters\NotesMasterTableAdapter.cs | CSharp | SHA256 | 3f080d2767838561f77be84cd4d17969893648407bfaef836a8064f13f922535 | 150 | 24 | 1 | 30-417 |
| 692 | RPOS_DBDataSetTableAdapters\OtherSettingTableAdapter.cs | CSharp | SHA256 | 5d242bd2afb262061b60c383dea1a71f85bbcf0885c656850f947d8cbb2147c9 | 376 | 24 | 1 | 33-782 |
| 693 | RPOS_DBDataSetTableAdapters\PaymentTableAdapter.cs | CSharp | SHA256 | 6ae833e4e2ec1424017ec0b2097aba5013207e6f2c59e4ec8fd65c3c5031107f | 270 | 24 | 1 | 30-593 |
| 694 | RPOS_DBDataSetTableAdapters\PizzaMasterTableAdapter.cs | CSharp | SHA256 | e8ea1ef0a9a8d5902c326c857a531f6c081dc5aac52f4419413c40df61d468e6 | 281 | 24 | 1 | 33-631 |
| 695 | RPOS_DBDataSetTableAdapters\PizzaSizeTableAdapter.cs | CSharp | SHA256 | 0456fe172f0bf7109cedd41f799524e09dd5c0d41c46f13c2fc92f6434bdcb7e | 143 | 24 | 1 | 30-410 |
| 696 | RPOS_DBDataSetTableAdapters\PizzaToppingTableAdapter.cs | CSharp | SHA256 | bec82b6b054520d387af854abce54d8693f804278ce9cd53434c6668de01071a | 243 | 24 | 1 | 33-569 |
| 697 | RPOS_DBDataSetTableAdapters\PosGrouping1TableAdapter.cs | CSharp | SHA256 | 415645a3c7b400c364694008fb202760aff2b93d084c647e1b42915a24a3c7cc | 549 | 24 | 1 | 33-1059 |
| 698 | RPOS_DBDataSetTableAdapters\PosGroupingTableAdapter.cs | CSharp | SHA256 | 7cc85ea019b0fbe50890d9a15f95f126a6950f52a8683ecc7e3ffffba7a4ae9a | 549 | 24 | 1 | 30-1056 |
| 699 | RPOS_DBDataSetTableAdapters\PosPrinterSettingTableAdapter.cs | CSharp | SHA256 | 13fc122859a4b34ee779fabb3f579aa206eeea5cd3f7343cffaf0c17eeb94dea | 349 | 24 | 1 | 30-736 |
| 700 | RPOS_DBDataSetTableAdapters\Product_OpeningStockTableAdapter.cs | CSharp | SHA256 | ee89492a0ede202842faa5d4df18457ec31426c0e46a77bb7694901c068eda12 | 222 | 24 | 1 | 30-521 |
| 701 | RPOS_DBDataSetTableAdapters\ProductTableAdapter.cs | CSharp | SHA256 | 41d3c829153c2d8121cb9d4446bcf8197da4de8ec7e3add67f7b7ca5c7edf6b4 | 252 | 24 | 1 | 33-570 |
| 702 | RPOS_DBDataSetTableAdapters\Purchase_JoinTableAdapter.cs | CSharp | SHA256 | 51a47232a9cfeba4f686068afe7230cec0765288a2dacc38f53e5de3d8b1786d | 249 | 24 | 1 | 30-548 |
| 703 | RPOS_DBDataSetTableAdapters\PurchaseTableAdapter.cs | CSharp | SHA256 | a11e6d959355ac204f96f8973115e8f498af70ec99264738a03d4fdb03766847 | 351 | 24 | 1 | 33-669 |
| 704 | RPOS_DBDataSetTableAdapters\R_TableTableAdapter.cs | CSharp | SHA256 | f242c6f69693ee83df8d7765c6aba4b2ce64b1809d073a12fe1d0d95aeaaacdb | 169 | 24 | 1 | 33-447 |
| 705 | RPOS_DBDataSetTableAdapters\Recipe_JoinTableAdapter.cs | CSharp | SHA256 | a5027d3ca0dc7f0853b6d33c2c1005898d8fdee9fe6c81472ed2712a8ebc139d | 177 | 24 | 1 | 33-447 |
| 706 | RPOS_DBDataSetTableAdapters\RecipeTableAdapter.cs | CSharp | SHA256 | 570c6dfe04403c6caf07f6f3dd29047462aefd6f6f0f233b4771cde61866f3cf | 189 | 24 | 1 | 30-472 |
| 707 | RPOS_DBDataSetTableAdapters\RegistrationTableAdapter.cs | CSharp | SHA256 | 896e7d37630b28ba058a4294b10f0ecb3390295eef3baa63bf516d768ba38f83 | 284 | 24 | 1 | 30-623 |
| 708 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoEBTableAdapter.cs | CSharp | SHA256 | f763ff14429c2e79dad6c735708bfe012ee7c79294cf96a75c183ff70032c173 | 523 | 24 | 1 | 33-1009 |
| 709 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoHDTableAdapter.cs | CSharp | SHA256 | ca8a01f37a5787a789e117262dedd70a1d722a2a25afe0fb0e7cb8c0269d2139 | 540 | 24 | 1 | 30-1031 |
| 710 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoKOTTableAdapter.cs | CSharp | SHA256 | 50d16facc633da784666eb16704f32cc4631e85f0c4c8f36ebb17e171fbc2b60 | 486 | 24 | 1 | 33-956 |
| 711 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoTATableAdapter.cs | CSharp | SHA256 | fec0f418d0433dc87e0d8a9c094ac0a9c6a30519d1e8e18d11bffd76404f6513 | 577 | 24 | 1 | 30-1092 |
| 712 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillEBTableAdapter.cs | CSharp | SHA256 | 5f6f660ab5cf5bf14b8aec913ea354613eaf95810f0e70b2fee46d80caa7dc11 | 549 | 24 | 1 | 33-1059 |
| 713 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillHDTableAdapter.cs | CSharp | SHA256 | d1142e4d1d21df3c6f77dd4bd4ae040f68a60344a74a3a09a787ee182efb1525 | 549 | 24 | 1 | 30-1056 |
| 714 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillKOTTableAdapter.cs | CSharp | SHA256 | d05ae48e7f41763218c6a1d59818e54af651943def2db2f4e657a2293966dba5 | 565 | 24 | 1 | 33-1083 |
| 715 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillTATableAdapter.cs | CSharp | SHA256 | 35086c9853011a2fd2f4db57fc09ed546ac147a3cc86f384dd6ed379e6164d95 | 549 | 24 | 1 | 30-1056 |
| 716 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductKOTTableAdapter.cs | CSharp | SHA256 | 67f0bb726e9dd167af7d4b9db8b1db0fa839ed048b9d02827db6527f4c4a1a40 | 576 | 24 | 1 | 33-1102 |
| 717 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderInfoKOTTableAdapter.cs | CSharp | SHA256 | 3532d6166992dc7b830991b5c0abba63c481c8da93245b524847ccb577149965 | 307 | 24 | 1 | 30-662 |
| 718 | RPOS_DBDataSetTableAdapters\SMSSettingTableAdapter.cs | CSharp | SHA256 | 2a68d7748b99e5508de2477eebcfab9a90be02a9de69733206fd0e0cf4918d39 | 176 | 24 | 1 | 33-458 |
| 719 | RPOS_DBDataSetTableAdapters\Stock_Store_JoinTableAdapter.cs | CSharp | SHA256 | 52234b4209d21e44f056e97842aad5d8cb75d8c452c190125316abd787cbd3e1 | 168 | 24 | 1 | 33-438 |
| 720 | RPOS_DBDataSetTableAdapters\Stock_StoreTableAdapter.cs | CSharp | SHA256 | 7a12ad2fadca669bfbd3d9878f3156cca628aa98706747a40cf74d5dd094fc7c | 161 | 24 | 1 | 30-428 |
| 721 | RPOS_DBDataSetTableAdapters\StockTransfer_JoinTableAdapter.cs | CSharp | SHA256 | 8a062dfc168df63ec065e3ef1a3a1bb966b704e3e7e523641c10acfbb4d631d1 | 204 | 24 | 1 | 33-490 |
| 722 | RPOS_DBDataSetTableAdapters\StockTransferTableAdapter.cs | CSharp | SHA256 | 33ca5e9877a126c632b310cb769880801bc1446b55cf1d40c9ffdf85f12f7b31 | 161 | 24 | 1 | 30-428 |
| 723 | RPOS_DBDataSetTableAdapters\SupplierLedgerBookTableAdapter.cs | CSharp | SHA256 | 8da9d41674f291e930b5ea7b8ec2ae06d1619e7eba43d0767c5ebe02a3021409 | 238 | 24 | 1 | 33-540 |
| 724 | RPOS_DBDataSetTableAdapters\SupplierTableAdapter.cs | CSharp | SHA256 | 59277a1e846a299a61ca6ea301cf12427339d10e74db990147342d81908b8d15 | 649 | 24 | 1 | 30-1212 |
| 725 | RPOS_DBDataSetTableAdapters\tblOrderTableAdapter.cs | CSharp | SHA256 | ab0e503589b5ebed541d56736b90150fb1896f45dd971742d308bb39ddcbecba | 169 | 24 | 1 | 30-444 |
| 726 | RPOS_DBDataSetTableAdapters\Temp_Stock_RMTableAdapter.cs | CSharp | SHA256 | 4fbaf0579a713bcb5666c4e2ef6a9c0fc8911abd84d6673631bb042f3e60dc4b | 151 | 24 | 1 | 30-410 |
| 727 | RPOS_DBDataSetTableAdapters\Temp_Stock_StoreTableAdapter.cs | CSharp | SHA256 | 118734cd9f336effda5acfee316308e1d42446aaacedffeac07b391a01785fd9 | 159 | 24 | 1 | 33-429 |
| 728 | RPOS_DBDataSetTableAdapters\Temp_StockTableAdapter.cs | CSharp | SHA256 | 0d6742ec4369da92a2fb5d16afda6164713e690f0882ec9fc150c9f1b0c51cb6 | 222 | 24 | 1 | 33-524 |
| 729 | RPOS_DBDataSetTableAdapters\Voucher_OtherDetailsTableAdapter.cs | CSharp | SHA256 | 38e5984d0a559e2a22230af0f5431c400fbdf6e3a8ee635a450fe5431f0b958f | 179 | 24 | 1 | 33-457 |
| 730 | RPOS_DBDataSetTableAdapters\VoucherTableAdapter.cs | CSharp | SHA256 | 0766ea718fb4d90fa9c777312cb88e17effa4c5cc43270f4c3ecf97690b73469 | 225 | 24 | 1 | 30-524 |
| 731 | RPOS_DBDataSetTableAdapters\WalletTableAdapter.cs | CSharp | SHA256 | fd58ce32c68fc7101f3c930593301ef8f83e20effde2542df850e17ae62317e6 | 143 | 24 | 1 | 30-410 |
| 732 | RPOS_DBDataSetTableAdapters\WarehouseTableAdapter.cs | CSharp | SHA256 | ec7ab4de46b4c0e935f28b9d6f3c751035b1886f4f558cf2becf3d9167696f2d | 194 | 24 | 1 | 33-488 |
| 733 | RPOS_DBDataSetTableAdapters\WarehouseTypeTableAdapter.cs | CSharp | SHA256 | bc6b4cbe54e711e996b2a7f7d0b219c57dc5ee226ea612be96fb599e0350f91b | 143 | 24 | 1 | 30-410 |
| 734 | RPOS_DBDataSetTableAdapters\WorkPeriodEndTableAdapter.cs | CSharp | SHA256 | 95c9c8e7c4f587d87f5addbbc48a1345ef12c901ec18e8fcab9513492979f8a4 | 144 | 24 | 1 | 33-406 |
| 735 | RPOS_DBDataSetTableAdapters\WorkPeriodStartTableAdapter.cs | CSharp | SHA256 | 0f75374e2a512da04b51a718a62ac5a229f1a0a067f1c47fe8e9e637d4e8a05d | 159 | 24 | 1 | 30-426 |
| 736 | rptBalanceReceipt.cs | CSharp | SHA256 | 85437ba25ca5ec218beb987885bb337da2436243e4daaf30132fb914c1be46bd | 41 | 18 | 1 | 21-211 |
| 737 | rptBalanceSheet.cs | CSharp | SHA256 | bace1ea80a04cc7f69e9c82e07642507bc1c8622c93139d17be13e60691f5119 | 42 | 19 | 1 | 21-223 |
| 738 | rptBankAccountStatements.cs | CSharp | SHA256 | 6f35135dd9b2d56fdc60399b562ae8822e574b12a84ca7b47bd167610fb3567f | 39 | 16 | 1 | 21-187 |
| 739 | rptBankAccountStatements1.cs | CSharp | SHA256 | 920754a6607dd4adcbea2eed52d7f415b0d180493b4061621f4cbbd4793f5a43 | 39 | 16 | 1 | 21-187 |
| 740 | rptBarcodeLabelPrinting.cs | CSharp | SHA256 | 1e02daf5619262b827ccb936432e2239ba9f74b36aed96c07d0ee05dca81f537 | 38 | 15 | 1 | 21-175 |
| 741 | rptCollectionsByDP.cs | CSharp | SHA256 | fbebb7365eefa3694c8f83765be38c261edd134b77a6359946492f4bb5d40717 | 41 | 18 | 1 | 21-211 |
| 742 | rptCollectionsByDP1.cs | CSharp | SHA256 | 7b89c02f1b338eee522927717c56ded9edd96b5fb7f0183d38537ca31fff4df7 | 41 | 18 | 1 | 21-211 |
| 743 | rptCollectionsByWaiter.cs | CSharp | SHA256 | 9282633a4fed2d4c2310884866f14d16185b7ab893d6726b2f96223a1c886879 | 41 | 18 | 1 | 21-211 |
| 744 | rptCreditCustomerBalance.cs | CSharp | SHA256 | 00481844c7709e9cf4e89f57d7d5cfbaee3edcce2ed8d885ed4ef198e8134818 | 37 | 14 | 1 | 20-162 |
| 745 | rptCreditCustomerLedger.cs | CSharp | SHA256 | 83845dd8e3b62aeeda9129e31cb4769970a3941bcdad346b742cf27cbecbe414 | 43 | 20 | 1 | 21-235 |
| 746 | rptCreditCustomerLedger1.cs | CSharp | SHA256 | e9d1d054c2295f3ca0108cd4577717a9629b250331e8878245a7d1c6f73ccfdf | 42 | 19 | 1 | 21-223 |
| 747 | rptCreditors.cs | CSharp | SHA256 | 69388ff728f3bc885db9164b4ad1dcb459770a7bdec6df8113461b96a4af437d | 38 | 15 | 1 | 21-175 |
| 748 | rptDeletedBills.cs | CSharp | SHA256 | f7137e111dcd2b687f8820aca0935087dca3dad7d5a9f460e3b2fdb87301fa16 | 39 | 16 | 1 | 21-187 |
| 749 | rptDeletedItems.cs | CSharp | SHA256 | 20c00d92c92a31d30620d85d505733dbd6595422bb7a8489675541c80bc0ff9c | 39 | 16 | 1 | 21-187 |
| 750 | rptExpenses.cs | CSharp | SHA256 | 9535e414900299d5400d642062d35293f84f56d00aa23f76495d8088ca7fe8c9 | 45 | 22 | 1 | 21-259 |
| 751 | rptFundDepositReceipt.cs | CSharp | SHA256 | 894302f28229d5a9c3039eaa4d792d198089b7e0edc73e72436e5abba64356df | 39 | 16 | 1 | 20-186 |
| 752 | rptGeneralDayBook.cs | CSharp | SHA256 | 9e008dfc15319ce93be3192129600da334052a7e5a4fc12e2d15ea4e2653350f | 39 | 16 | 1 | 21-187 |
| 753 | rptGeneralLedger.cs | CSharp | SHA256 | cb4b5cc2a174e907bfeb75f3e2e2d514e2e683149c26a803300351282a20a6e2 | 42 | 19 | 1 | 21-223 |
| 754 | rptGiftCard.cs | CSharp | SHA256 | f23a9b9f4834fd01d989901f81b3980000033ee628b9870effa4caee071c8519 | 37 | 14 | 1 | 20-162 |
| 755 | rptInputTax.cs | CSharp | SHA256 | a91b4d4489bf664a2b1970a291d93de083dcb624b9c13701e0d519d707d964ce | 39 | 16 | 1 | 21-187 |
| 756 | rptInvoiceSummary_CC.cs | CSharp | SHA256 | 04c300cd734b8b3f927e91a40794305c68fc9c5cbd9098815f59ce83d8353dac | 41 | 18 | 1 | 21-211 |
| 757 | rptLoyaltyCard.cs | CSharp | SHA256 | 60f7959eb2ea15be5df6d03d4ac23c22571846e0fa34449bafe720eacbeae10a | 38 | 15 | 1 | 21-175 |
| 758 | rptLoyaltyCardMemberBalance.cs | CSharp | SHA256 | 8a833648ae7e936a5dfe371e71e6d404d6dacbeb580460a584378d5bfa63b65a | 37 | 14 | 1 | 20-162 |
| 759 | rptLoyaltyCardMemberLedger.cs | CSharp | SHA256 | c393935c8f40ac848d651ad0ad6aeefe55f52d8cdfc8be447b20167c9bb3a9f6 | 44 | 21 | 1 | 21-247 |
| 760 | rptLoyaltyCardMemberLedger1.cs | CSharp | SHA256 | b3ed68fb5735e8463925829b733d5ba6ec36db80c0bf422d980719fae726f508 | 44 | 21 | 1 | 21-247 |
| 761 | rptMemberBalance.cs | CSharp | SHA256 | 0525b3b6a21289b7bc51e4554c238e78422f6ac240e269075f914c89195b5f4a | 37 | 14 | 1 | 20-162 |
| 762 | rptMemberLedger.cs | CSharp | SHA256 | 92017c52803557830ede94c68626081066ffb7c2a555fadf8ec120f0e2063a7b | 44 | 21 | 1 | 21-247 |
| 763 | rptMemberLedger1.cs | CSharp | SHA256 | 96b16bb5228e9988e4b5b8c3822fdf298085435c5cb4f9ba36266adcf2eb994a | 44 | 21 | 1 | 21-247 |
| 764 | rptMenuItems.cs | CSharp | SHA256 | 49e9e57970328c89ddd60f94428715284cc1fbdac5704f8b87658ca43df2dcb2 | 79 | 18 | 1 | 20-243 |
| 765 | rptPayment_WithdrawalReceipt.cs | CSharp | SHA256 | 99e9b8eb527c70430b13fddc68098540e4b71a5945a34d0e80c46030da8ed470 | 39 | 16 | 1 | 20-186 |
| 766 | rptPaymentInvoice.cs | CSharp | SHA256 | 0c16ea6bbd10cfd1c391c9758e0f5171c7cbbec7cf8641c248c292b6cdb98263 | 42 | 19 | 1 | 21-223 |
| 767 | rptPOS80mmByOperator.cs | CSharp | SHA256 | 9016462fe5d977706de62d888f5f2f67730740fb39353fcc3a7001d4dcdc4d41 | 120 | 21 | 1 | 22-351 |
| 768 | rptPOSA4.cs | CSharp | SHA256 | 7f176b6a083db7265616eec0223021c62d09ea7059a58d7aa5a4915383ebc764 | 87 | 16 | 1 | 21-238 |
| 769 | rptPOSA4ByOperator.cs | CSharp | SHA256 | 56e07a5e0ad0842631019204454b7ae4e79acf56ce9086ecd803a22836af26e0 | 40 | 17 | 1 | 21-199 |
| 770 | rptPOSA4X.cs | CSharp | SHA256 | 122ba3382fda53b9ed7864170cd3a15a96aa50d144bea71d9fbd3981519f4a82 | 39 | 16 | 1 | 21-187 |
| 771 | rptPurchase.cs | CSharp | SHA256 | 0bc3dd64dbb9a6bbac4b28dd30c4c7c9f7af500d82034091af1d896fe84ef100 | 43 | 20 | 1 | 21-235 |
| 772 | rptPurchaseDayBook.cs | CSharp | SHA256 | fed1a683353000210610829b7c790b7cd228951500dfb3cb82f525853aae4834 | 41 | 18 | 1 | 21-211 |
| 773 | rptPurchaseOrder.cs | CSharp | SHA256 | b588f410a4e50e3f9dd8af0371ee70b4890af37fca07ff771c553dfae2904c74 | 41 | 18 | 1 | 21-211 |
| 774 | rptReceipt.cs | CSharp | SHA256 | 81e6202a61e4d0983fd1014da2e6393b1b50d6ddeff7b72a49d1ebcbab09292b | 148 | 19 | 1 | 22-369 |
| 775 | rptReceiptTP.cs | CSharp | SHA256 | 49d759767f50d424523204a476da762a0ffa1ce50c6d8e6e0c8ef66dc3be3427 | 146 | 17 | 1 | 22-345 |
| 776 | rptRecipe.cs | CSharp | SHA256 | 9fcbca5dc78678ca1746107989fe3174604980a0375bd89f0ada994a3a36c693 | 43 | 20 | 1 | 21-235 |
| 777 | rptRestaurantPOS.cs | CSharp | SHA256 | ccca30122f1b25459da1ad087fa724ccbc9986b04522a4ad2923461f00dd4be4 | 140 | 21 | 1 | 22-379 |
| 778 | rptRestaurantPOSEB.cs | CSharp | SHA256 | cac0b3f066a3b6df1acf8f523c93db756ac3f13c7f9e713bc3ade15d8f0bc09d | 44 | 21 | 1 | 21-247 |
| 779 | rptRestaurantPOSEBInvoice_Kitchen.cs | CSharp | SHA256 | 7cd40b1e764b99c187f931326db41dfc65b4d31aa56f2cff62e6015de01edfa9 | 45 | 22 | 1 | 21-259 |
| 780 | rptRestaurantPOSEBInvoice.cs | CSharp | SHA256 | 8db0c27c8bb0a51ecc34817f30f8071df8805ad13ddb15705d9878f91e5cff89 | 137 | 43 | 1 | 21-593 |
| 781 | rptRestaurantPOSFinalBillKOTInvoice.cs | CSharp | SHA256 | 0a415d2569cc36728ba18369512eba8f412b536f95db29364d3c6cc8ad3efb49 | 161 | 43 | 1 | 22-638 |
| 782 | rptRestaurantPOSHD.cs | CSharp | SHA256 | 5588ba64b091afefee1abf77ce69c58a9d88c4bef2d015aae8276351eb016fd2 | 44 | 21 | 1 | 21-247 |
| 783 | rptRestaurantPOSHDInvoice_Kitchen.cs | CSharp | SHA256 | 550866bae22b7442920f59c8b2254a91b936071c2ceb58a54795df0e7b9a5ad2 | 45 | 22 | 1 | 21-259 |
| 784 | rptRestaurantPOSHDInvoice.cs | CSharp | SHA256 | 7b509adfcfb618107945216424e024d923acc3bd96eb9a4da8c93868ed67d59d | 164 | 42 | 1 | 22-634 |
| 785 | rptRestaurantPOSKOTInvoice_Kitchen.cs | CSharp | SHA256 | ac1e71ad6e84597d90e8c61b8d5f2e58acb99a35061050809a41244dfb28cc19 | 117 | 23 | 1 | 21-353 |
| 786 | rptRestaurantPOSTA.cs | CSharp | SHA256 | 0dc59bc7771220ab425ed88966c74b11036a916e9959fa8443ef5b655c0d0651 | 44 | 21 | 1 | 21-247 |
| 787 | rptRestaurantPOSTAInvoice_Kitchen.cs | CSharp | SHA256 | ba7b98e0fcec22429e095dafa8c768605ab81dd6b22ef3583b72a38adb3813f4 | 45 | 22 | 1 | 21-259 |
| 788 | rptRestaurantPOSTAInvoice.cs | CSharp | SHA256 | 24c631a29b3ff93b0ae002321ec880dc8a66dd33cd502b23321de0082e1553fc | 139 | 45 | 1 | 21-617 |
| 789 | rptRestaurantPOSUpdatedKOTInvoice_Kitchen.cs | CSharp | SHA256 | 4c90a1f823049733b7f264cb201e7bd26de23cca1ad8391c8b00f017e91a5b89 | 117 | 23 | 1 | 21-353 |
| 790 | rptRestaurantPOSVoidKOT_Kitchen.cs | CSharp | SHA256 | d179812b0f9a465d0319cbeef180aca34db6d9a2093fdacc797e84cab03225c5 | 108 | 20 | 1 | 21-307 |
| 791 | rptRPOS.cs | CSharp | SHA256 | 490827801d665dcfcbfd2c74e96cfc6904d93efd515d6a361a03aabde9bd6069 | 161 | 67 | 1 | 21-881 |
| 792 | rptRPOS1.cs | CSharp | SHA256 | fe182e5441a2792a2f9b1dfe392f228d6c3f0fcb9d626c3961f3d1d43feb5c7c | 185 | 67 | 1 | 22-926 |
| 793 | rptRPOS2.cs | CSharp | SHA256 | 7bb44532c8d3b1806c89b1438cea47d2641963048d3cf352fb9fcaf0ec003eed | 161 | 67 | 1 | 21-881 |
| 794 | rptRPOSByKitchen.cs | CSharp | SHA256 | 07780acf588adbe2feea76eb1b1c796cdd3cf25e8faa6942995e155f38bf7104 | 44 | 21 | 1 | 21-247 |
| 795 | rptRPOSByMonth.cs | CSharp | SHA256 | 5c0d22041c4254d48ca0ee37093a7fa854862e1d323ccc9b26a5aff26150044f | 40 | 17 | 1 | 21-199 |
| 796 | rptRPOSCard.cs | CSharp | SHA256 | b2d8159e15e2f3dc164cfe0fd1a14204009687602da82f55c4405be0f5c1c8ed | 38 | 15 | 1 | 21-175 |
| 797 | rptSalarySlip_MB.cs | CSharp | SHA256 | 06873d11c717054e16afeed5edc64db127a2687446b8616d269cfb57df33fa47 | 37 | 14 | 1 | 20-162 |
| 798 | rptSalarySlip.cs | CSharp | SHA256 | d91c04bbe2780abfa99c83b8c7b6f6a3bbea60176aec1a499fd907b24d79fffb | 37 | 14 | 1 | 20-162 |
| 799 | rptStockTransfer.cs | CSharp | SHA256 | 6f1f1ce8f1c4d7752d81b66cac1b327dabc132eea67029640591d62259c932a2 | 43 | 20 | 1 | 21-235 |
| 800 | rptStockTransferInvoice.cs | CSharp | SHA256 | ea0ff7aaae9f87b1260f8d6015fee2531240bfbf7a11b930b4a66a8a42f0a8bb | 43 | 20 | 1 | 21-235 |
| 801 | rptSupplierLedger.cs | CSharp | SHA256 | ccb3a062d9a240032cfd7d8b548790fd2db9875de8c53437998a9de057e22ac1 | 46 | 23 | 1 | 21-271 |
| 802 | rptTax.cs | CSharp | SHA256 | f793c32a330adcaabb5b7b6d0ddcef869da059dd6250e3c23413e2f04105d4d9 | 39 | 16 | 1 | 21-187 |
| 803 | rptTrialBalance.cs | CSharp | SHA256 | bd6b8dd4e35205ce92c127cc51309cf275d998d0450ca085ce123348c2bde4bf | 39 | 16 | 1 | 21-187 |
| 804 | rptVoidKOT.cs | CSharp | SHA256 | 4b5992acf1ff3ec2db646ef5dd5762eaa7b7db44ff7819f8fe9da429a7dab86e | 41 | 18 | 1 | 21-211 |
| 805 | rptVoucher.cs | CSharp | SHA256 | 3e2489ae945ade4cfbdf38419d9955634fe302406e579f23d9636dc451cb14c6 | 39 | 16 | 1 | 20-186 |
| 806 | rptWPByKitchen.cs | CSharp | SHA256 | 484e2757920745a7373a0106063a7c4397dee11d366f8be9564812c8e439757d | 44 | 21 | 1 | 21-247 |
| 807 | System\Runtime\CompilerServices\RefSafetyRulesAttribute.cs | CSharp | SHA256 | 3c611ee8f778737346285de5b986cf11f429569d991088f793347a4f4377439c | 3 | 1 | 1 | 13-16 |

## Full type inventory by namespace

Counts are members declared on that metadata type. Nested types are listed separately and are not included in the member total. PDB documents are relative to the symbol source root above.

### `(global)`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| &lt;&gt;f__AnonymousType0`1 | class | internal | yes | 1 | 5 | 1 | 0 | 7 | (none) |
| &lt;&gt;f__AnonymousType1`4 | class | internal | yes | 4 | 8 | 4 | 0 | 16 | (none) |
| &lt;&gt;f__AnonymousType2`2 | class | internal | yes | 2 | 6 | 2 | 0 | 10 | (none) |
| &lt;Module&gt; | class | internal | yes | 0 | 0 | 0 | 0 | 0 | (none) |

### `Microsoft.CodeAnalysis`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| EmbeddedAttribute | class | internal | yes | 0 | 1 | 0 | 0 | 1 | (none) |

### `RestaurantPOS14`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| CachedrptBalanceReceipt | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptBalanceReceipt.cs |
| CachedrptBalanceSheet | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptBalanceSheet.cs |
| CachedrptBankAccountStatements | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptBankAccountStatements.cs |
| CachedrptBankAccountStatements1 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptBankAccountStatements1.cs |
| CachedrptBarcodeLabelPrinting | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptBarcodeLabelPrinting.cs |
| CachedrptCollectionsByDP | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCollectionsByDP.cs |
| CachedrptCollectionsByDP1 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCollectionsByDP1.cs |
| CachedrptCollectionsByWaiter | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCollectionsByWaiter.cs |
| CachedrptCreditCustomerBalance | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCreditCustomerBalance.cs |
| CachedrptCreditCustomerLedger | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCreditCustomerLedger.cs |
| CachedrptCreditCustomerLedger1 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCreditCustomerLedger1.cs |
| CachedrptCreditors | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptCreditors.cs |
| CachedrptDeletedBills | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptDeletedBills.cs |
| CachedrptDeletedItems | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptDeletedItems.cs |
| CachedrptExpenses | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptExpenses.cs |
| CachedrptFundDepositReceipt | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptFundDepositReceipt.cs |
| CachedrptGeneralDayBook | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptGeneralDayBook.cs |
| CachedrptGeneralLedger | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptGeneralLedger.cs |
| CachedrptGiftCard | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptGiftCard.cs |
| CachedrptInputTax | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptInputTax.cs |
| CachedrptInvoiceSummary_CC | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptInvoiceSummary_CC.cs |
| CachedrptLoyaltyCard | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptLoyaltyCard.cs |
| CachedrptLoyaltyCardMemberBalance | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptLoyaltyCardMemberBalance.cs |
| CachedrptLoyaltyCardMemberLedger | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptLoyaltyCardMemberLedger.cs |
| CachedrptLoyaltyCardMemberLedger1 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptLoyaltyCardMemberLedger1.cs |
| CachedrptMemberBalance | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptMemberBalance.cs |
| CachedrptMemberLedger | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptMemberLedger.cs |
| CachedrptMemberLedger1 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptMemberLedger1.cs |
| CachedrptMenuItems | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptMenuItems.cs |
| CachedrptPayment_WithdrawalReceipt | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPayment_WithdrawalReceipt.cs |
| CachedrptPaymentInvoice | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPaymentInvoice.cs |
| CachedrptPOS80mmByOperator | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPOS80mmByOperator.cs |
| CachedrptPOSA4 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPOSA4.cs |
| CachedrptPOSA4ByOperator | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPOSA4ByOperator.cs |
| CachedrptPOSA4X | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPOSA4X.cs |
| CachedrptPurchase | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPurchase.cs |
| CachedrptPurchaseDayBook | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPurchaseDayBook.cs |
| CachedrptPurchaseOrder | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptPurchaseOrder.cs |
| CachedrptReceipt | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptReceipt.cs |
| CachedrptReceiptTP | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptReceiptTP.cs |
| CachedrptRecipe | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRecipe.cs |
| CachedrptRestaurantPOS | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOS.cs |
| CachedrptRestaurantPOSEB | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSEB.cs |
| CachedrptRestaurantPOSEBInvoice | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSEBInvoice.cs |
| CachedrptRestaurantPOSEBInvoice_Kitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSEBInvoice_Kitchen.cs |
| CachedrptRestaurantPOSFinalBillKOTInvoice | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSFinalBillKOTInvoice.cs |
| CachedrptRestaurantPOSHD | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSHD.cs |
| CachedrptRestaurantPOSHDInvoice | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSHDInvoice.cs |
| CachedrptRestaurantPOSHDInvoice_Kitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSHDInvoice_Kitchen.cs |
| CachedrptRestaurantPOSKOTInvoice_Kitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSKOTInvoice_Kitchen.cs |
| CachedrptRestaurantPOSTA | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSTA.cs |
| CachedrptRestaurantPOSTAInvoice | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSTAInvoice.cs |
| CachedrptRestaurantPOSTAInvoice_Kitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSTAInvoice_Kitchen.cs |
| CachedrptRestaurantPOSUpdatedKOTInvoice_Kitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSUpdatedKOTInvoice_Kitchen.cs |
| CachedrptRestaurantPOSVoidKOT_Kitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRestaurantPOSVoidKOT_Kitchen.cs |
| CachedrptRPOS | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRPOS.cs |
| CachedrptRPOS1 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRPOS1.cs |
| CachedrptRPOS2 | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRPOS2.cs |
| CachedrptRPOSByKitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRPOSByKitchen.cs |
| CachedrptRPOSByMonth | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRPOSByMonth.cs |
| CachedrptRPOSCard | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptRPOSCard.cs |
| CachedrptSalarySlip | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptSalarySlip.cs |
| CachedrptSalarySlip_MB | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptSalarySlip_MB.cs |
| CachedrptStockTransfer | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptStockTransfer.cs |
| CachedrptStockTransferInvoice | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptStockTransferInvoice.cs |
| CachedrptSupplierLedger | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptSupplierLedger.cs |
| CachedrptTax | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptTax.cs |
| CachedrptTrialBalance | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptTrialBalance.cs |
| CachedrptVoidKOT | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptVoidKOT.cs |
| CachedrptVoucher | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptVoucher.cs |
| CachedrptWPByKitchen | class | public | no | 1 | 13 | 3 | 0 | 17 | CachedrptWPByKitchen.cs |
| ConnectionString | class | internal | no | 2 | 3 | 0 | 0 | 5 | ConnectionString.cs |
| Encryption | class | public | no | 0 | 7 | 0 | 0 | 7 | Encryption.cs |
| frmAbout | class | public | no | 10 | 23 | 8 | 0 | 41 | frmAbout.cs<br>frmAbout.Designer.cs |
| frmAccountingReport | class | public | no | 60 | 140 | 52 | 0 | 252 | frmAccountingReport.cs<br>frmAccountingReport.Designer.cs |
| frmAddFunds | class | public | no | 32 | 82 | 30 | 0 | 144 | frmAddFunds.cs<br>frmAddFunds.Designer.cs |
| frmAddFundsRecord | class | public | no | 25 | 61 | 23 | 0 | 109 | frmAddFundsRecord.cs<br>frmAddFundsRecord.Designer.cs |
| frmAdvancedSettings | class | public | no | 13 | 8 | 0 | 0 | 21 | frmAdvancedSettings.cs |
| frmAssignedTablesList_Waiter | class | public | no | 8 | 17 | 4 | 0 | 29 | frmAssignedTablesList_Waiter.cs<br>frmAssignedTablesList_Waiter.Designer.cs |
| frmAttendance | class | public | no | 12 | 37 | 10 | 0 | 59 | frmAttendance.cs<br>frmAttendance.Designer.cs |
| frmAvailableTables | class | public | no | 9 | 20 | 5 | 0 | 34 | frmAvailableTables.cs<br>frmAvailableTables.Designer.cs |
| frmBackOffice | class | public | no | 58 | 165 | 56 | 0 | 279 | frmBackOffice.cs<br>frmBackOffice.Designer.cs |
| frmBank | class | public | no | 18 | 47 | 16 | 0 | 81 | frmBank.cs<br>frmBank.Designer.cs |
| frmBankAccountRegistration | class | public | no | 64 | 145 | 62 | 0 | 271 | frmBankAccountRegistration.cs<br>frmBankAccountRegistration.Designer.cs |
| frmBankAccountStatements | class | public | no | 32 | 57 | 22 | 0 | 111 | frmBankAccountStatements.cs<br>frmBankAccountStatements.Designer.cs |
| frmBankReconciliation | class | public | no | 11 | 32 | 9 | 0 | 52 | frmBankReconciliation.cs<br>frmBankReconciliation.Designer.cs |
| frmBarcodeLabelPrinting | class | public | no | 26 | 62 | 23 | 0 | 111 | frmBarcodeLabelPrinting.cs<br>frmBarcodeLabelPrinting.Designer.cs |
| frmBillSplit | class | public | no | 130 | 264 | 105 | 0 | 499 | frmBillSplit.cs<br>frmBillSplit.Designer.cs |
| frmBranchMaster_Bank | class | public | no | 35 | 85 | 33 | 0 | 153 | frmBranchMaster_Bank.cs<br>frmBranchMaster_Bank.Designer.cs |
| frmCallerID | class | public | no | 12 | 28 | 9 | 0 | 49 | frmCallerID.cs<br>frmCallerID.Designer.cs |
| frmCards | class | public | no | 7 | 19 | 5 | 0 | 31 | frmCards.cs<br>frmCards.Designer.cs |
| frmCards_POS | class | public | no | 12 | 25 | 7 | 0 | 44 | frmCards_POS.cs<br>frmCards_POS.Designer.cs |
| frmCategoriesExportImport | class | public | no | 16 | 44 | 14 | 0 | 74 | frmCategoriesExportImport.cs<br>frmCategoriesExportImport.Designer.cs |
| frmChangeQty | class | public | no | 31 | 69 | 23 | 0 | 123 | frmChangeQty.cs<br>frmChangeQty.Designer.cs |
| frmChangeRate | class | public | no | 31 | 69 | 23 | 0 | 123 | frmChangeRate.cs<br>frmChangeRate.Designer.cs |
| frmClockINandOUT | class | public | no | 9 | 27 | 7 | 0 | 43 | frmClockINandOUT.cs<br>frmClockINandOUT.Designer.cs |
| frmCMISetting | class | public | no | 16 | 39 | 14 | 0 | 69 | frmCMISetting.cs<br>frmCMISetting.Designer.cs |
| frmCreditCustomer | class | public | no | 7 | 19 | 5 | 0 | 31 | frmCreditCustomer.cs<br>frmCreditCustomer.Designer.cs |
| frmCreditCustomerBalance | class | public | no | 19 | 49 | 17 | 0 | 85 | frmCreditCustomerBalance.cs<br>frmCreditCustomerBalance.Designer.cs |
| frmCreditCustomerLedger | class | public | no | 37 | 73 | 30 | 0 | 140 | frmCreditCustomerLedger.cs<br>frmCreditCustomerLedger.Designer.cs |
| frmCreditCustomerReceipt | class | public | no | 55 | 113 | 46 | 0 | 214 | frmCreditCustomerReceipt.cs<br>frmCreditCustomerReceipt.Designer.cs |
| frmCreditCustomerReceiptRecord | class | public | no | 32 | 75 | 30 | 0 | 137 | frmCreditCustomerReceiptRecord.cs<br>frmCreditCustomerReceiptRecord.Designer.cs |
| frmCreditCustomerRegistration | class | public | no | 44 | 103 | 41 | 0 | 188 | frmCreditCustomerRegistration.cs<br>frmCreditCustomerRegistration.Designer.cs |
| frmCreditCustomersList | class | public | no | 15 | 38 | 13 | 0 | 66 | frmCreditCustomersList.cs<br>frmCreditCustomersList.Designer.cs |
| frmCurrency | class | public | no | 25 | 64 | 23 | 0 | 112 | frmCurrency.cs<br>frmCurrency.Designer.cs |
| frmCustomDialog1 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog1.cs<br>frmCustomDialog1.Designer.cs |
| frmCustomDialog10 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog10.cs<br>frmCustomDialog10.Designer.cs |
| frmCustomDialog11 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog11.cs<br>frmCustomDialog11.Designer.cs |
| frmCustomDialog12 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog12.cs<br>frmCustomDialog12.Designer.cs |
| frmCustomDialog13 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog13.cs<br>frmCustomDialog13.Designer.cs |
| frmCustomDialog14 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog14.cs<br>frmCustomDialog14.Designer.cs |
| frmCustomDialog15 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog15.cs<br>frmCustomDialog15.Designer.cs |
| frmCustomDialog16 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog16.cs<br>frmCustomDialog16.Designer.cs |
| frmCustomDialog17 | class | public | no | 7 | 18 | 5 | 0 | 30 | frmCustomDialog17.cs<br>frmCustomDialog17.Designer.cs |
| frmCustomDialog18 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog18.cs<br>frmCustomDialog18.Designer.cs |
| frmCustomDialog19 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog19.cs<br>frmCustomDialog19.Designer.cs |
| frmCustomDialog19X | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog19X.cs<br>frmCustomDialog19X.Designer.cs |
| frmCustomDialog2 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog2.cs<br>frmCustomDialog2.Designer.cs |
| frmCustomDialog20 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog20.cs<br>frmCustomDialog20.Designer.cs |
| frmCustomDialog21 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog21.cs<br>frmCustomDialog21.Designer.cs |
| frmCustomDialog3 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog3.cs<br>frmCustomDialog3.Designer.cs |
| frmCustomDialog4 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog4.cs<br>frmCustomDialog4.Designer.cs |
| frmCustomDialog4X | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog4X.cs<br>frmCustomDialog4X.Designer.cs |
| frmCustomDialog5 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog5.cs<br>frmCustomDialog5.Designer.cs |
| frmCustomDialog6 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog6.cs<br>frmCustomDialog6.Designer.cs |
| frmCustomDialog7 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog7.cs<br>frmCustomDialog7.Designer.cs |
| frmCustomDialog8 | class | public | no | 7 | 18 | 5 | 0 | 30 | frmCustomDialog8.cs<br>frmCustomDialog8.Designer.cs |
| frmCustomDialog8X | class | public | no | 8 | 20 | 5 | 0 | 33 | frmCustomDialog8X.cs<br>frmCustomDialog8X.Designer.cs |
| frmCustomDialog9 | class | public | no | 5 | 12 | 3 | 0 | 20 | frmCustomDialog9.cs<br>frmCustomDialog9.Designer.cs |
| frmCustomDialogWS | class | public | no | 4 | 9 | 2 | 0 | 15 | frmCustomDialogWS.cs<br>frmCustomDialogWS.Designer.cs |
| frmCustomDialogX | class | public | no | 12 | 29 | 10 | 0 | 51 | frmCustomDialogX.cs<br>frmCustomDialogX.Designer.cs |
| frmCustomDialogX1 | class | public | no | 8 | 20 | 6 | 0 | 34 | frmCustomDialogX1.cs<br>frmCustomDialogX1.Designer.cs |
| frmCustomDialogX2 | class | public | no | 8 | 22 | 6 | 0 | 36 | frmCustomDialogX2.cs<br>frmCustomDialogX2.Designer.cs |
| frmCustomer | class | public | no | 32 | 79 | 30 | 0 | 141 | frmCustomer.cs<br>frmCustomer.Designer.cs |
| frmCustomersExportImport | class | public | no | 19 | 51 | 17 | 0 | 87 | frmCustomersExportImport.cs<br>frmCustomersExportImport.Designer.cs |
| frmCustomersRecord | class | public | no | 25 | 67 | 23 | 0 | 115 | frmCustomersRecord.cs<br>frmCustomersRecord.Designer.cs |
| frmDatabase | class | public | no | 9 | 22 | 6 | 0 | 37 | frmDatabase.cs<br>frmDatabase.Designer.cs |
| frmDelete | class | public | no | 3 | 9 | 1 | 0 | 13 | frmDelete.cs<br>frmDelete.Designer.cs |
| frmDeliveryPersonLedger | class | public | no | 26 | 60 | 24 | 0 | 110 | frmDeliveryPersonLedger.cs<br>frmDeliveryPersonLedger.Designer.cs |
| frmDeliveryPersonRecord | class | public | no | 22 | 55 | 20 | 0 | 97 | frmDeliveryPersonRecord.cs<br>frmDeliveryPersonRecord.Designer.cs |
| frmEInvoicePreview | class | public | no | 7 | 7 | 0 | 0 | 14 | frmEInvoicePreview.cs |
| frmEmailSetting | class | public | no | 37 | 84 | 32 | 0 | 153 | frmEmailSetting.cs<br>frmEmailSetting.Designer.cs |
| frmEmployeeRegistration | class | public | no | 40 | 86 | 35 | 0 | 161 | frmEmployeeRegistration.cs<br>frmEmployeeRegistration.Designer.cs |
| frmEmployeeSession | class | public | no | 24 | 61 | 22 | 0 | 107 | frmEmployeeSession.cs<br>frmEmployeeSession.Designer.cs |
| frmEmployeesRecord | class | public | no | 23 | 56 | 21 | 0 | 100 | frmEmployeesRecord.cs<br>frmEmployeesRecord.Designer.cs |
| frmEnterQty | class | public | no | 31 | 69 | 23 | 0 | 123 | frmEnterQty.cs<br>frmEnterQty.Designer.cs |
| frmEnterQtyX | class | public | no | 31 | 69 | 23 | 0 | 123 | frmEnterQtyX.cs<br>frmEnterQtyX.Designer.cs |
| frmExecuteQuery | class | public | no | 8 | 18 | 5 | 0 | 31 | frmExecuteQuery.cs<br>frmExecuteQuery.Designer.cs |
| frmExpense | class | public | no | 25 | 65 | 23 | 0 | 113 | frmExpense.cs<br>frmExpense.Designer.cs |
| frmExpenseType | class | public | no | 18 | 47 | 16 | 0 | 81 | frmExpenseType.cs<br>frmExpenseType.Designer.cs |
| frmExpiredProductsRecord | class | public | no | 23 | 55 | 21 | 0 | 99 | frmExpiredProductsRecord.cs<br>frmExpiredProductsRecord.Designer.cs |
| frmFreeToppingsList | class | public | no | 24 | 27 | 7 | 0 | 58 | frmFreeToppingsList.cs<br>frmFreeToppingsList.Designer.cs |
| frmFrontOffice | class | public | no | 26 | 64 | 22 | 0 | 112 | frmFrontOffice.cs<br>frmFrontOffice.Designer.cs |
| frmFrontOffice_Report | class | public | no | 9 | 22 | 7 | 0 | 38 | frmFrontOffice_Report.cs<br>frmFrontOffice_Report.Designer.cs |
| frmFundDeposit | class | public | no | 60 | 143 | 58 | 0 | 261 | frmFundDeposit.cs<br>frmFundDeposit.Designer.cs |
| frmFundTransfer | class | public | no | 68 | 157 | 66 | 0 | 291 | frmFundTransfer.cs<br>frmFundTransfer.Designer.cs |
| frmGeneralLedger | class | public | no | 24 | 46 | 17 | 0 | 87 | frmGeneralLedger.cs<br>frmGeneralLedger.Designer.cs |
| frmGiftCard | class | public | no | 28 | 70 | 25 | 0 | 123 | frmGiftCard.cs<br>frmGiftCard.Designer.cs |
| frmGiftCardRecord | class | public | no | 11 | 29 | 9 | 0 | 49 | frmGiftCardRecord.cs<br>frmGiftCardRecord.Designer.cs |
| frmHDStatus | class | public | no | 10 | 27 | 8 | 0 | 45 | frmHDStatus.cs<br>frmHDStatus.Designer.cs |
| frmHoldBills | class | public | no | 13 | 31 | 11 | 0 | 55 | frmHoldBills.cs<br>frmHoldBills.Designer.cs |
| frmHoldBillsHD | class | public | no | 14 | 33 | 12 | 0 | 59 | frmHoldBillsHD.cs<br>frmHoldBillsHD.Designer.cs |
| frmHoldDineInKOTs | class | public | no | 12 | 29 | 10 | 0 | 51 | frmHoldDineInKOTs.cs<br>frmHoldDineInKOTs.Designer.cs |
| frmHomeDelivery | class | public | no | 9 | 20 | 6 | 0 | 35 | frmHomeDelivery.cs<br>frmHomeDelivery.Designer.cs |
| frmImportExportExcel_Products | class | public | no | 30 | 72 | 28 | 0 | 130 | frmImportExportExcel_Products.cs<br>frmImportExportExcel_Products.Designer.cs |
| frmImportExportExcel_Supplier | class | public | no | 35 | 82 | 33 | 0 | 150 | frmImportExportExcel_Supplier.cs<br>frmImportExportExcel_Supplier.Designer.cs |
| frmItemsTransfer | class | public | no | 63 | 124 | 53 | 0 | 240 | frmItemsTransfer.cs<br>frmItemsTransfer.Designer.cs |
| frmJournalEntries | class | public | no | 53 | 127 | 50 | 0 | 230 | frmJournalEntries.cs<br>frmJournalEntries.Designer.cs |
| frmKDS | class | public | no | 22 | 48 | 18 | 0 | 88 | frmKDS.cs<br>frmKDS.Designer.cs |
| frmKitchen_Section | class | public | no | 30 | 72 | 27 | 0 | 129 | frmKitchen_Section.cs<br>frmKitchen_Section.Designer.cs |
| frmLogin | class | public | no | 48 | 122 | 40 | 0 | 210 | frmLogin.cs<br>frmLogin.Designer.cs |
| frmLogs | class | public | no | 32 | 79 | 30 | 0 | 141 | frmLogs.cs<br>frmLogs.Designer.cs |
| frmLowStockRecord | class | public | no | 18 | 44 | 16 | 0 | 78 | frmLowStockRecord.cs<br>frmLowStockRecord.Designer.cs |
| frmLoyaltyCard | class | public | no | 8 | 22 | 6 | 0 | 36 | frmLoyaltyCard.cs<br>frmLoyaltyCard.Designer.cs |
| frmLoyaltyCardMemberLedger | class | public | no | 31 | 65 | 26 | 0 | 122 | frmLoyaltyCardMemberLedger.cs<br>frmLoyaltyCardMemberLedger.Designer.cs |
| frmLoyaltyCardMemberList | class | public | no | 12 | 31 | 10 | 0 | 53 | frmLoyaltyCardMemberList.cs<br>frmLoyaltyCardMemberList.Designer.cs |
| frmLoyaltyCardMemberPoints | class | public | no | 19 | 50 | 17 | 0 | 86 | frmLoyaltyCardMemberPoints.cs<br>frmLoyaltyCardMemberPoints.Designer.cs |
| frmLoyaltyMember | class | public | no | 37 | 86 | 34 | 0 | 157 | frmLoyaltyMember.cs<br>frmLoyaltyMember.Designer.cs |
| frmLoyaltySetting | class | public | no | 25 | 61 | 22 | 0 | 108 | frmLoyaltySetting.cs<br>frmLoyaltySetting.Designer.cs |
| frmMarketingTools | class | public | no | 7 | 18 | 5 | 0 | 30 | frmMarketingTools.cs<br>frmMarketingTools.Designer.cs |
| frmMember | class | public | no | 34 | 80 | 31 | 0 | 145 | frmMember.cs<br>frmMember.Designer.cs |
| frmMemberBalance | class | public | no | 19 | 49 | 17 | 0 | 85 | frmMemberBalance.cs<br>frmMemberBalance.Designer.cs |
| frmMemberLedger | class | public | no | 31 | 65 | 26 | 0 | 122 | frmMemberLedger.cs<br>frmMemberLedger.Designer.cs |
| frmMemberList | class | public | no | 11 | 29 | 9 | 0 | 49 | frmMemberList.cs<br>frmMemberList.Designer.cs |
| frmMenuItem | class | public | no | 66 | 158 | 62 | 0 | 286 | frmMenuItem.cs<br>frmMenuItem.Designer.cs |
| frmMenuItemsCategory | class | public | no | 35 | 90 | 33 | 0 | 158 | frmMenuItemsCategory.cs<br>frmMenuItemsCategory.Designer.cs |
| frmMenuItemsExportImport | class | public | no | 28 | 70 | 25 | 0 | 123 | frmMenuItemsExportImport.cs<br>frmMenuItemsExportImport.Designer.cs |
| frmMenuItemsList | class | public | no | 12 | 31 | 10 | 0 | 53 | frmMenuItemsList.cs<br>frmMenuItemsList.Designer.cs |
| frmMenuItemsModifiers | class | public | no | 35 | 92 | 33 | 0 | 160 | frmMenuItemsModifiers.cs<br>frmMenuItemsModifiers.Designer.cs |
| frmModifiersExportImport | class | public | no | 16 | 44 | 14 | 0 | 74 | frmModifiersExportImport.cs<br>frmModifiersExportImport.Designer.cs |
| frmModifiersList | class | public | no | 37 | 51 | 18 | 0 | 106 | frmModifiersList.cs<br>frmModifiersList.Designer.cs |
| frmModifiersList_AutoPopUp | class | public | no | 32 | 36 | 13 | 0 | 81 | frmModifiersList_AutoPopUp.cs<br>frmModifiersList_AutoPopUp.Designer.cs |
| frmMpesaSetting | class | public | no | 19 | 41 | 16 | 0 | 76 | frmMpesaSetting.cs<br>frmMpesaSetting.Designer.cs |
| frmNotes | class | public | no | 13 | 35 | 10 | 0 | 58 | frmNotes.cs<br>frmNotes.Designer.cs |
| frmNotes1 | class | public | no | 13 | 34 | 10 | 0 | 57 | frmNotes1.cs<br>frmNotes1.Designer.cs |
| frmNotesMaster | class | public | no | 18 | 47 | 16 | 0 | 81 | frmNotesMaster.cs<br>frmNotesMaster.Designer.cs |
| frmOnscreenKeyboard | class | public | no | 52 | 108 | 48 | 0 | 208 | frmOnscreenKeyboard.cs<br>frmOnscreenKeyboard.Designer.cs |
| frmOpenItems | class | public | no | 13 | 30 | 10 | 0 | 53 | frmOpenItems.cs<br>frmOpenItems.Designer.cs |
| frmOpenTicketsRecord | class | public | no | 28 | 67 | 26 | 0 | 121 | frmOpenTicketsRecord.cs<br>frmOpenTicketsRecord.Designer.cs |
| frmOption | class | public | no | 13 | 34 | 11 | 0 | 58 | frmOption.cs<br>frmOption.Designer.cs |
| frmOrderedItemDetails | class | public | no | 16 | 34 | 14 | 0 | 64 | frmOrderedItemDetails.cs<br>frmOrderedItemDetails.Designer.cs |
| frmOthersSetting | class | public | no | 79 | 143 | 62 | 0 | 284 | frmOthersSetting.cs<br>frmOthersSetting.Designer.cs |
| frmPayment | class | public | no | 57 | 115 | 47 | 0 | 219 | frmPayment.cs<br>frmPayment.Designer.cs |
| frmPayment_Withdrawal | class | public | no | 63 | 148 | 61 | 0 | 272 | frmPayment_Withdrawal.cs<br>frmPayment_Withdrawal.Designer.cs |
| frmPaymentRecord | class | public | no | 36 | 74 | 30 | 0 | 140 | frmPaymentRecord.cs<br>frmPaymentRecord.Designer.cs |
| frmPayroll | class | public | no | 6 | 16 | 4 | 0 | 26 | frmPayroll.cs<br>frmPayroll.Designer.cs |
| frmPayroll_HB | class | public | no | 64 | 154 | 61 | 0 | 279 | frmPayroll_HB.cs<br>frmPayroll_HB.Designer.cs |
| frmPayroll_MB | class | public | no | 64 | 154 | 61 | 0 | 279 | frmPayroll_MB.cs<br>frmPayroll_MB.Designer.cs |
| frmPayroll_MBRecord | class | public | no | 20 | 51 | 18 | 0 | 89 | frmPayroll_MBRecord.cs<br>frmPayroll_MBRecord.Designer.cs |
| frmPayrollRecord_HB | class | public | no | 20 | 52 | 18 | 0 | 90 | frmPayrollRecord_HB.cs<br>frmPayrollRecord_HB.Designer.cs |
| frmPizza | class | public | no | 8 | 22 | 6 | 0 | 36 | frmPizza.cs<br>frmPizza.Designer.cs |
| frmPizzaMaster | class | public | no | 39 | 100 | 37 | 0 | 176 | frmPizzaMaster.cs<br>frmPizzaMaster.Designer.cs |
| frmPizzaModifiers | class | public | no | 37 | 96 | 35 | 0 | 168 | frmPizzaModifiers.cs<br>frmPizzaModifiers.Designer.cs |
| frmPizzaModifiersList | class | public | no | 38 | 57 | 21 | 0 | 116 | frmPizzaModifiersList.cs<br>frmPizzaModifiersList.Designer.cs |
| frmPizzaModifiersList_AutoPopUp | class | public | no | 38 | 57 | 21 | 0 | 116 | frmPizzaModifiersList_AutoPopUp.cs<br>frmPizzaModifiersList_AutoPopUp.Designer.cs |
| frmPizzaPOS | class | public | no | 68 | 118 | 44 | 0 | 230 | frmPizzaPOS.cs<br>frmPizzaPOS.Designer.cs |
| frmPizzasExportImport | class | public | no | 18 | 49 | 16 | 0 | 83 | frmPizzasExportImport.cs<br>frmPizzasExportImport.Designer.cs |
| frmPizzaSize | class | public | no | 18 | 47 | 16 | 0 | 81 | frmPizzaSize.cs<br>frmPizzaSize.Designer.cs |
| frmPizzaToppings | class | public | no | 36 | 93 | 34 | 0 | 163 | frmPizzaToppings.cs<br>frmPizzaToppings.Designer.cs |
| frmPizzaToppingsExportImport | class | public | no | 17 | 46 | 15 | 0 | 78 | frmPizzaToppingsExportImport.cs<br>frmPizzaToppingsExportImport.Designer.cs |
| frmPO_CRViewer | class | public | no | 8 | 21 | 6 | 0 | 35 | frmPO_CRViewer.cs<br>frmPO_CRViewer.Designer.cs |
| frmPOS | class | public | no | 831 | 2087 | 735 | 0 | 3653 | frmPOS.cs<br>frmPOS.Designer.cs |
| frmPOS+&lt;&lt;frmRestaurantPOS_Load&gt;b__2511_13&gt;d | struct | nested private | yes | 4 | 2 | 0 | 0 | 6 | frmPOS.cs |
| frmPOS+&lt;AcquireTokenAsync&gt;d__2521 | struct | nested private | yes | 4 | 2 | 0 | 0 | 6 | frmPOS.cs |
| frmPOS+&lt;BuildPayloadAsync&gt;d__2525 | struct | nested private | yes | 22 | 2 | 0 | 0 | 24 | frmPOS.cs |
| frmPOS+&lt;GetNextQueueAsync&gt;d__2522 | struct | nested private | yes | 3 | 2 | 0 | 0 | 5 | frmPOS.cs |
| frmPOS+&lt;GetUINAsync&gt;d__2524 | struct | nested private | yes | 7 | 2 | 0 | 0 | 9 | frmPOS.cs |
| frmPOS+&lt;MarkErrorAsync&gt;d__2526 | struct | nested private | yes | 8 | 2 | 0 | 0 | 10 | frmPOS.cs |
| frmPOS+&lt;ProcessEInvoiceQueueAsync&gt;d__2523 | struct | nested private | yes | 18 | 2 | 0 | 0 | 20 | frmPOS.cs |
| frmPOS+&lt;UpdateQueueStatusAsync&gt;d__2527 | struct | nested private | yes | 8 | 2 | 0 | 0 | 10 | frmPOS.cs |
| frmPOS+LastActionType | enum | nested private | no | 4 | 0 | 0 | 0 | 4 | (none) |
| frmPOSRecord | class | public | no | 38 | 85 | 36 | 0 | 159 | frmPOSRecord.cs<br>frmPOSRecord.Designer.cs |
| frmPOSReport | class | public | no | 68 | 107 | 39 | 0 | 214 | frmPOSReport.cs<br>frmPOSReport.Designer.cs |
| frmPOSReport_CRViewer | class | public | no | 38 | 29 | 9 | 0 | 76 | frmPOSReport_CRViewer.cs<br>frmPOSReport_CRViewer.Designer.cs |
| frmPOSReport_CRViewer1 | class | public | no | 38 | 29 | 9 | 0 | 76 | frmPOSReport_CRViewer1.cs<br>frmPOSReport_CRViewer1.Designer.cs |
| frmPrinterStatus | class | public | no | 8 | 17 | 4 | 0 | 29 | frmPrinterStatus.cs<br>frmPrinterStatus.Designer.cs |
| frmPrintLoyaltyCard | class | public | no | 16 | 40 | 13 | 0 | 69 | frmPrintLoyaltyCard.cs<br>frmPrintLoyaltyCard.Designer.cs |
| frmPrintVIPMemberCard | class | public | no | 16 | 40 | 13 | 0 | 69 | frmPrintVIPMemberCard.cs<br>frmPrintVIPMemberCard.Designer.cs |
| frmProduct | class | public | no | 55 | 141 | 52 | 0 | 248 | frmProduct.cs<br>frmProduct.Designer.cs |
| frmProductRecord | class | public | no | 30 | 71 | 28 | 0 | 129 | frmProductRecord.cs<br>frmProductRecord.Designer.cs |
| frmPromotion | class | public | no | 43 | 102 | 40 | 0 | 185 | frmPromotion.cs<br>frmPromotion.Designer.cs |
| frmPurchaseEntry | class | public | no | 106 | 231 | 90 | 0 | 427 | frmPurchaseEntry.cs<br>frmPurchaseEntry.Designer.cs |
| frmPurchaseOrder | class | public | no | 87 | 187 | 71 | 0 | 345 | frmPurchaseOrder.cs<br>frmPurchaseOrder.Designer.cs |
| frmPurchaseOrderRecord | class | public | no | 36 | 82 | 34 | 0 | 152 | frmPurchaseOrderRecord.cs<br>frmPurchaseOrderRecord.Designer.cs |
| frmPurchaseRecord | class | public | no | 42 | 94 | 40 | 0 | 176 | frmPurchaseRecord.cs<br>frmPurchaseRecord.Designer.cs |
| frmRawMaterialsCategory | class | public | no | 18 | 48 | 16 | 0 | 82 | frmRawMaterialsCategory.cs<br>frmRawMaterialsCategory.Designer.cs |
| frmRawMaterialsUsed | class | public | no | 18 | 43 | 16 | 0 | 77 | frmRawMaterialsUsed.cs<br>frmRawMaterialsUsed.Designer.cs |
| frmRecipe | class | public | no | 49 | 131 | 47 | 0 | 227 | frmRecipe.cs<br>frmRecipe.Designer.cs |
| frmRecipeRecord | class | public | no | 17 | 42 | 15 | 0 | 74 | frmRecipeRecord.cs<br>frmRecipeRecord.Designer.cs |
| frmRecoveryPIN | class | public | no | 10 | 32 | 8 | 0 | 50 | frmRecoveryPIN.cs<br>frmRecoveryPIN.Designer.cs |
| frmRefundMoney | class | public | no | 32 | 82 | 30 | 0 | 144 | frmRefundMoney.cs<br>frmRefundMoney.Designer.cs |
| frmRefundMoneyRecord | class | public | no | 25 | 61 | 23 | 0 | 109 | frmRefundMoneyRecord.cs<br>frmRefundMoneyRecord.Designer.cs |
| frmRegistration | class | public | no | 55 | 126 | 51 | 0 | 232 | frmRegistration.cs<br>frmRegistration.Designer.cs |
| frmReport | class | public | no | 7 | 17 | 5 | 0 | 29 | frmReport.cs<br>frmReport.Designer.cs |
| frmRestaurantMaster | class | public | no | 71 | 151 | 67 | 0 | 289 | frmRestaurantMaster.cs<br>frmRestaurantMaster.Designer.cs |
| frmRestaurantPOSEBRecord | class | public | no | 45 | 104 | 43 | 0 | 192 | frmRestaurantPOSEBRecord.cs<br>frmRestaurantPOSEBRecord.Designer.cs |
| frmRestaurantPOSEBRecord_Unpaid | class | public | no | 43 | 100 | 41 | 0 | 184 | frmRestaurantPOSEBRecord_Unpaid.cs<br>frmRestaurantPOSEBRecord_Unpaid.Designer.cs |
| frmRestaurantPOSHDRecord | class | public | no | 46 | 106 | 44 | 0 | 196 | frmRestaurantPOSHDRecord.cs<br>frmRestaurantPOSHDRecord.Designer.cs |
| frmRestaurantPOSHDRecord1 | class | public | no | 45 | 104 | 43 | 0 | 192 | frmRestaurantPOSHDRecord1.cs<br>frmRestaurantPOSHDRecord1.Designer.cs |
| frmRestaurantPOSKOTFinalBillRecord | class | public | no | 47 | 108 | 45 | 0 | 200 | frmRestaurantPOSKOTFinalBillRecord.cs<br>frmRestaurantPOSKOTFinalBillRecord.Designer.cs |
| frmRestaurantPOSKOTFinalBillRecord_Unpaid | class | public | no | 47 | 107 | 45 | 0 | 199 | frmRestaurantPOSKOTFinalBillRecord_Unpaid.cs<br>frmRestaurantPOSKOTFinalBillRecord_Unpaid.Designer.cs |
| frmRestaurantPOSKOTRecord | class | public | no | 31 | 75 | 29 | 0 | 135 | frmRestaurantPOSKOTRecord.cs<br>frmRestaurantPOSKOTRecord.Designer.cs |
| frmRestaurantPOSTARecord | class | public | no | 47 | 108 | 45 | 0 | 200 | frmRestaurantPOSTARecord.cs<br>frmRestaurantPOSTARecord.Designer.cs |
| frmRestaurantPOSTARecord_Unpaid | class | public | no | 46 | 106 | 44 | 0 | 196 | frmRestaurantPOSTARecord_Unpaid.cs<br>frmRestaurantPOSTARecord_Unpaid.Designer.cs |
| frmSecondaryDisplay | class | public | no | 26 | 51 | 20 | 0 | 97 | frmSecondaryDisplay.cs<br>frmSecondaryDisplay.Designer.cs |
| frmSendBroadcastSMS | class | public | no | 17 | 34 | 12 | 0 | 63 | frmSendBroadcastSMS.cs<br>frmSendBroadcastSMS.Designer.cs |
| frmSendEmail | class | public | no | 22 | 45 | 17 | 0 | 84 | frmSendEmail.cs<br>frmSendEmail.Designer.cs |
| frmSetDiscount | class | public | no | 26 | 58 | 18 | 0 | 102 | frmSetDiscount.cs<br>frmSetDiscount.Designer.cs |
| frmSetNOP | class | public | no | 25 | 57 | 17 | 0 | 99 | frmSetNOP.cs<br>frmSetNOP.Designer.cs |
| frmSettings | class | public | no | 24 | 70 | 22 | 0 | 116 | frmSettings.cs<br>frmSettings.Designer.cs |
| frmSMSSetting | class | public | no | 25 | 54 | 20 | 0 | 99 | frmSMSSetting.cs<br>frmSMSSetting.Designer.cs |
| frmSoftwareLicenceRenewal | class | public | no | 19 | 45 | 17 | 0 | 81 | frmSoftwareLicenceRenewal.cs<br>frmSoftwareLicenceRenewal.Designer.cs |
| frmSplash | class | public | no | 13 | 28 | 11 | 0 | 52 | frmSplash.cs<br>frmSplash.Designer.cs |
| frmSqlServerSetting | class | public | no | 29 | 68 | 25 | 0 | 122 | frmSqlServerSetting.cs<br>frmSqlServerSetting.Designer.cs |
| frmStock_Store | class | public | no | 34 | 84 | 30 | 0 | 148 | frmStock_Store.cs<br>frmStock_Store.Designer.cs |
| frmStock_StoreRecord | class | public | no | 20 | 52 | 18 | 0 | 90 | frmStock_StoreRecord.cs<br>frmStock_StoreRecord.Designer.cs |
| frmStockAdjustment | class | public | no | 7 | 19 | 5 | 0 | 31 | frmStockAdjustment.cs<br>frmStockAdjustment.Designer.cs |
| frmStockAdjustment_MI | class | public | no | 33 | 80 | 30 | 0 | 143 | frmStockAdjustment_MI.cs<br>frmStockAdjustment_MI.Designer.cs |
| frmStockAdjustment_MI_Record | class | public | no | 27 | 65 | 25 | 0 | 117 | frmStockAdjustment_MI_Record.cs<br>frmStockAdjustment_MI_Record.Designer.cs |
| frmStockAdjustment_Store | class | public | no | 36 | 86 | 33 | 0 | 155 | frmStockAdjustment_Store.cs<br>frmStockAdjustment_Store.Designer.cs |
| frmStockAdjustment_Store_Record | class | public | no | 30 | 70 | 28 | 0 | 128 | frmStockAdjustment_Store_Record.cs<br>frmStockAdjustment_Store_Record.Designer.cs |
| frmStockAdjustment_Warehouse | class | public | no | 38 | 92 | 35 | 0 | 165 | frmStockAdjustment_Warehouse.cs<br>frmStockAdjustment_Warehouse.Designer.cs |
| frmStockAdjustment_Warehouse_Record | class | public | no | 31 | 72 | 29 | 0 | 132 | frmStockAdjustment_Warehouse_Record.cs<br>frmStockAdjustment_Warehouse_Record.Designer.cs |
| frmStockIn_RM | class | public | no | 15 | 37 | 13 | 0 | 65 | frmStockIn_RM.cs<br>frmStockIn_RM.Designer.cs |
| frmStockIn_StoreRecord | class | public | no | 14 | 35 | 12 | 0 | 61 | frmStockIn_StoreRecord.cs<br>frmStockIn_StoreRecord.Designer.cs |
| frmStockInRecord | class | public | no | 24 | 57 | 22 | 0 | 103 | frmStockInRecord.cs<br>frmStockInRecord.Designer.cs |
| frmStockOUT_RM | class | public | no | 13 | 33 | 11 | 0 | 57 | frmStockOUT_RM.cs<br>frmStockOUT_RM.Designer.cs |
| frmStockOUT_StoreRecord | class | public | no | 12 | 31 | 10 | 0 | 53 | frmStockOUT_StoreRecord.cs<br>frmStockOUT_StoreRecord.Designer.cs |
| frmStockOUTRecord | class | public | no | 15 | 38 | 13 | 0 | 66 | frmStockOUTRecord.cs<br>frmStockOUTRecord.Designer.cs |
| frmStockTransfer | class | public | no | 55 | 135 | 53 | 0 | 243 | frmStockTransfer.cs<br>frmStockTransfer.Designer.cs |
| frmStockTransferRecord | class | public | no | 22 | 58 | 20 | 0 | 100 | frmStockTransferRecord.cs<br>frmStockTransferRecord.Designer.cs |
| frmSupplier | class | public | no | 57 | 131 | 55 | 0 | 243 | frmSupplier.cs<br>frmSupplier.Designer.cs |
| frmSupplierRecord | class | public | no | 43 | 98 | 41 | 0 | 182 | frmSupplierRecord.cs<br>frmSupplierRecord.Designer.cs |
| frmSystemInfo | class | public | no | 68 | 134 | 61 | 0 | 263 | frmSystemInfo.cs<br>frmSystemInfo.Designer.cs |
| frmTable | class | public | no | 27 | 67 | 25 | 0 | 119 | frmTable.cs<br>frmTable.Designer.cs |
| frmTableLayout | class | public | no | 9 | 20 | 5 | 0 | 34 | frmTableLayout.cs<br>frmTableLayout.Designer.cs |
| frmTableLayoutSettings | class | public | no | 17 | 43 | 12 | 0 | 72 | frmTableLayoutSettings.cs<br>frmTableLayoutSettings.Designer.cs |
| frmTableList | class | public | no | 11 | 24 | 6 | 0 | 41 | frmTableList.cs<br>frmTableList.Designer.cs |
| frmTableMapping_Waiter | class | public | no | 26 | 69 | 24 | 0 | 119 | frmTableMapping_Waiter.cs<br>frmTableMapping_Waiter.Designer.cs |
| frmTableReservation | class | public | no | 65 | 151 | 62 | 0 | 278 | frmTableReservation.cs<br>frmTableReservation.Designer.cs |
| frmTablesExportImport | class | public | no | 14 | 39 | 12 | 0 | 65 | frmTablesExportImport.cs<br>frmTablesExportImport.Designer.cs |
| frmTerminalSetting | class | public | no | 73 | 147 | 63 | 0 | 283 | frmTerminalSetting.cs<br>frmTerminalSetting.Designer.cs |
| frmTestDualDisplay | class | public | no | 3 | 7 | 1 | 0 | 11 | frmTestDualDisplay.cs<br>frmTestDualDisplay.Designer.cs |
| frmToppingsList | class | public | no | 40 | 64 | 23 | 0 | 127 | frmToppingsList.cs<br>frmToppingsList.Designer.cs |
| frmToppingsList1 | class | public | no | 40 | 64 | 23 | 0 | 127 | frmToppingsList1.cs<br>frmToppingsList1.Designer.cs |
| frmUnit | class | public | no | 19 | 49 | 17 | 0 | 85 | frmUnit.cs<br>frmUnit.Designer.cs |
| frmUserRights | class | public | no | 30 | 83 | 21 | 0 | 134 | frmUserRights.cs<br>frmUserRights.Designer.cs |
| frmVIPMemberCard | class | public | no | 9 | 25 | 7 | 0 | 41 | frmVIPMemberCard.cs<br>frmVIPMemberCard.Designer.cs |
| frmVoucher | class | public | no | 45 | 112 | 43 | 0 | 200 | frmVoucher.cs<br>frmVoucher.Designer.cs |
| frmVoucherRecord | class | public | no | 19 | 51 | 17 | 0 | 87 | frmVoucherRecord.cs<br>frmVoucherRecord.Designer.cs |
| frmWaiterList | class | public | no | 8 | 19 | 5 | 0 | 32 | frmWaiterList.cs<br>frmWaiterList.Designer.cs |
| frmWalletList | class | public | no | 21 | 44 | 16 | 0 | 81 | frmWalletList.cs<br>frmWalletList.Designer.cs |
| frmWalletType | class | public | no | 18 | 47 | 16 | 0 | 81 | frmWalletType.cs<br>frmWalletType.Designer.cs |
| frmWarehouse | class | public | no | 31 | 77 | 29 | 0 | 137 | frmWarehouse.cs<br>frmWarehouse.Designer.cs |
| frmWarehouseType | class | public | no | 18 | 47 | 16 | 0 | 81 | frmWarehouseType.cs<br>frmWarehouseType.Designer.cs |
| frmWorkPeriod | class | public | no | 53 | 57 | 21 | 0 | 131 | frmWorkPeriod.cs<br>frmWorkPeriod.Designer.cs |
| frmWorkPeriod_Del | class | public | no | 15 | 38 | 13 | 0 | 66 | frmWorkPeriod_Del.cs<br>frmWorkPeriod_Del.Designer.cs |
| frmWorkPeriodReport | class | public | no | 44 | 45 | 15 | 0 | 104 | frmWorkPeriodReport.cs<br>frmWorkPeriodReport.Designer.cs |
| frmWPReport_CRViewer | class | public | no | 38 | 30 | 9 | 0 | 77 | frmWPReport_CRViewer.cs<br>frmWPReport_CRViewer.Designer.cs |
| ModCashDrawer | class | internal | no | 0 | 1 | 0 | 0 | 1 | (none) |
| ModCashDrawer+RawPrinter | class | nested public | no | 0 | 9 | 0 | 0 | 9 | ModCashDrawer.cs |
| ModCashDrawer+RawPrinter+DOCINFO | struct | nested public | no | 3 | 0 | 0 | 0 | 3 | (none) |
| ModClasses | class | internal | no | 19 | 1 | 0 | 0 | 20 | (none) |
| ModFunc | class | internal | no | 1 | 63 | 0 | 0 | 64 | ModFunc.cs |
| modPanelExtension | class | internal | no | 0 | 2 | 0 | 0 | 2 | modPanelExtension.cs |
| MyButton | class | public | no | 1 | 3 | 0 | 0 | 4 | MyButton.cs |
| MyGlobal | class | public | no | 1 | 2 | 0 | 0 | 3 | MyGlobal.cs |
| RPOS_DBDataSet | class | public | no | 116 | 153 | 70 | 0 | 339 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ActivationDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ActivationRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ActivationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ActivationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+CategoryDataTable | class | nested public | no | 12 | 40 | 9 | 4 | 65 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CategoryRow | class | nested public | no | 1 | 28 | 8 | 0 | 37 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CategoryRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CategoryRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+CreditCustomerDataTable | class | nested public | no | 14 | 42 | 11 | 4 | 71 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerLedgerDataTable | class | nested public | no | 12 | 40 | 9 | 4 | 65 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerLedgerRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerLedgerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerLedgerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+CreditCustomerPaymentDataTable | class | nested public | no | 13 | 41 | 10 | 4 | 68 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerPaymentRow | class | nested public | no | 1 | 27 | 9 | 0 | 37 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerPaymentRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerPaymentRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+CreditCustomerRow | class | nested public | no | 1 | 35 | 9 | 0 | 45 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CreditCustomerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+CurrencyDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CurrencyRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CurrencyRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+CurrencyRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+DishDataTable | class | nested public | no | 14 | 42 | 11 | 4 | 71 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+DishRow | class | nested public | no | 1 | 40 | 10 | 0 | 51 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+DishRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+DishRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+EmailSettingDataTable | class | nested public | no | 14 | 42 | 11 | 4 | 71 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+EmailSettingRow | class | nested public | no | 1 | 19 | 9 | 0 | 29 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+EmailSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+EmailSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+EmployeeRegistrationDataTable | class | nested public | no | 15 | 43 | 12 | 4 | 74 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+EmployeeRegistrationRow | class | nested public | no | 1 | 24 | 10 | 0 | 35 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+EmployeeRegistrationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+EmployeeRegistrationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+ExpenseDataTable | class | nested public | no | 7 | 35 | 4 | 4 | 50 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ExpenseRow | class | nested public | no | 1 | 8 | 3 | 0 | 12 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ExpenseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ExpenseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+ExpenseTypeDataTable | class | nested public | no | 6 | 34 | 3 | 4 | 47 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ExpenseTypeRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ExpenseTypeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ExpenseTypeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+GridGroupingDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+GridGroupingRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+GridGroupingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+GridGroupingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+HDCustomerDataTable | class | nested public | no | 9 | 37 | 6 | 4 | 56 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+HDCustomerRow | class | nested public | no | 1 | 15 | 4 | 0 | 20 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+HDCustomerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+HDCustomerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+HotelDataTable | class | nested public | no | 19 | 47 | 16 | 4 | 86 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+HotelRow | class | nested public | no | 1 | 55 | 14 | 0 | 70 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+HotelRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+HotelRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+KitchenDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+KitchenRow | class | nested public | no | 1 | 9 | 3 | 0 | 13 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+KitchenRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+KitchenRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+LedgerBookDataTable | class | nested public | no | 13 | 41 | 10 | 4 | 68 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LedgerBookRow | class | nested public | no | 1 | 19 | 8 | 0 | 28 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LedgerBookRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LedgerBookRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+LogsDataTable | class | nested public | no | 9 | 37 | 6 | 4 | 56 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LogsRow | class | nested public | no | 1 | 11 | 5 | 0 | 17 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LogsRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LogsRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+LoyaltyMemberDataTable | class | nested public | no | 11 | 39 | 8 | 4 | 62 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltyMemberLedgerBookDataTable | class | nested public | no | 12 | 40 | 9 | 4 | 65 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltyMemberLedgerBookRow | class | nested public | no | 1 | 19 | 8 | 0 | 28 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltyMemberLedgerBookRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltyMemberLedgerBookRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+LoyaltyMemberRow | class | nested public | no | 1 | 24 | 6 | 0 | 31 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltyMemberRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltyMemberRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+LoyaltySettingDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltySettingRow | class | nested public | no | 1 | 11 | 3 | 0 | 15 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltySettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+LoyaltySettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+MemberDataTable | class | nested public | no | 11 | 39 | 8 | 4 | 62 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+MemberLedgerDataTable | class | nested public | no | 12 | 40 | 9 | 4 | 65 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+MemberLedgerRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+MemberLedgerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+MemberLedgerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+MemberRow | class | nested public | no | 1 | 24 | 6 | 0 | 31 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+MemberRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+MemberRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+NotesMasterDataTable | class | nested public | no | 7 | 35 | 4 | 4 | 50 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+NotesMasterRow | class | nested public | no | 1 | 5 | 2 | 0 | 8 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+NotesMasterRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+NotesMasterRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+OtherSettingDataTable | class | nested public | no | 15 | 43 | 12 | 4 | 74 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+OtherSettingRow | class | nested public | no | 1 | 39 | 10 | 0 | 50 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+OtherSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+OtherSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PaymentDataTable | class | nested public | no | 13 | 41 | 10 | 4 | 68 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PaymentRow | class | nested public | no | 1 | 27 | 9 | 0 | 37 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PaymentRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PaymentRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PizzaMasterDataTable | class | nested public | no | 12 | 40 | 9 | 4 | 65 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaMasterRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaMasterRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaMasterRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PizzaSizeDataTable | class | nested public | no | 6 | 34 | 3 | 4 | 47 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaSizeRow | class | nested public | no | 1 | 5 | 1 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaSizeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaSizeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PizzaToppingDataTable | class | nested public | no | 10 | 38 | 7 | 4 | 59 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaToppingRow | class | nested public | no | 1 | 21 | 6 | 0 | 28 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaToppingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PizzaToppingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PosGrouping1DataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosGrouping1Row | class | nested public | no | 1 | 67 | 17 | 0 | 85 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosGrouping1RowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosGrouping1RowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PosGroupingDataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosGroupingRow | class | nested public | no | 1 | 67 | 17 | 0 | 85 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosGroupingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosGroupingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PosPrinterSettingDataTable | class | nested public | no | 14 | 42 | 11 | 4 | 71 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosPrinterSettingRow | class | nested public | no | 1 | 35 | 9 | 0 | 45 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosPrinterSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PosPrinterSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Product_OpeningStockDataTable | class | nested public | no | 11 | 39 | 8 | 4 | 62 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Product_OpeningStockRow | class | nested public | no | 1 | 21 | 8 | 0 | 30 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Product_OpeningStockRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Product_OpeningStockRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+ProductDataTable | class | nested public | no | 13 | 41 | 10 | 4 | 68 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ProductRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ProductRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+ProductRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Purchase_JoinDataTable | class | nested public | no | 14 | 42 | 11 | 4 | 71 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Purchase_JoinRow | class | nested public | no | 1 | 29 | 12 | 0 | 42 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Purchase_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Purchase_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+PurchaseDataTable | class | nested public | no | 24 | 52 | 21 | 4 | 101 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PurchaseRow | class | nested public | no | 1 | 48 | 20 | 0 | 69 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PurchaseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+PurchaseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+R_TableDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+R_TableRow | class | nested public | no | 1 | 9 | 3 | 0 | 13 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+R_TableRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+R_TableRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Recipe_JoinDataTable | class | nested public | no | 10 | 38 | 7 | 4 | 59 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Recipe_JoinRow | class | nested public | no | 1 | 15 | 7 | 0 | 23 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Recipe_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Recipe_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RecipeDataTable | class | nested public | no | 10 | 38 | 7 | 4 | 59 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RecipeRow | class | nested public | no | 1 | 16 | 6 | 0 | 23 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RecipeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RecipeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RegistrationDataTable | class | nested public | no | 13 | 41 | 10 | 4 | 68 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RegistrationRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RegistrationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RegistrationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoEBDataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoEBRow | class | nested public | no | 1 | 66 | 18 | 0 | 85 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoEBRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoEBRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoHDDataTable | class | nested public | no | 23 | 51 | 20 | 4 | 98 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoHDRow | class | nested public | no | 1 | 70 | 20 | 0 | 91 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoHDRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoHDRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoKOTDataTable | class | nested public | no | 19 | 47 | 16 | 4 | 86 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoKOTRow | class | nested public | no | 1 | 58 | 15 | 0 | 74 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoTADataTable | class | nested public | no | 24 | 52 | 21 | 4 | 101 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoTARow | class | nested public | no | 1 | 74 | 20 | 0 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoTARowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_BillingInfoTARowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillEBDataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillEBRow | class | nested public | no | 1 | 69 | 18 | 0 | 88 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillEBRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillEBRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillHDDataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillHDRow | class | nested public | no | 1 | 69 | 18 | 0 | 88 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillHDRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillHDRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillKOTDataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillKOTRow | class | nested public | no | 1 | 71 | 19 | 0 | 91 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillTADataTable | class | nested public | no | 22 | 50 | 19 | 4 | 95 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillTARow | class | nested public | no | 1 | 69 | 18 | 0 | 88 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillTARowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductBillTARowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductKOTDataTable | class | nested public | no | 23 | 51 | 20 | 4 | 98 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductKOTRow | class | nested public | no | 1 | 73 | 19 | 0 | 93 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderedProductKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+RestaurantPOS_OrderInfoKOTDataTable | class | nested public | no | 14 | 42 | 11 | 4 | 71 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderInfoKOTRow | class | nested public | no | 1 | 36 | 11 | 0 | 48 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderInfoKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+RestaurantPOS_OrderInfoKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+SMSSettingDataTable | class | nested public | no | 9 | 37 | 6 | 4 | 56 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SMSSettingRow | class | nested public | no | 1 | 9 | 4 | 0 | 14 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SMSSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SMSSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Stock_Store_JoinDataTable | class | nested public | no | 9 | 37 | 6 | 4 | 56 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Stock_Store_JoinRow | class | nested public | no | 1 | 13 | 6 | 0 | 20 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Stock_Store_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Stock_Store_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Stock_StoreDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Stock_StoreRow | class | nested public | no | 1 | 8 | 3 | 0 | 12 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Stock_StoreRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Stock_StoreRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+StockTransfer_JoinDataTable | class | nested public | no | 11 | 39 | 8 | 4 | 62 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+StockTransfer_JoinRow | class | nested public | no | 1 | 21 | 9 | 0 | 31 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+StockTransfer_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+StockTransfer_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+StockTransferDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+StockTransferRow | class | nested public | no | 1 | 10 | 4 | 0 | 15 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+StockTransferRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+StockTransferRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+SupplierDataTable | class | nested public | no | 26 | 54 | 23 | 4 | 107 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SupplierLedgerBookDataTable | class | nested public | no | 13 | 41 | 10 | 4 | 68 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SupplierLedgerBookRow | class | nested public | no | 1 | 19 | 8 | 0 | 28 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SupplierLedgerBookRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SupplierLedgerBookRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+SupplierRow | class | nested public | no | 1 | 83 | 21 | 0 | 105 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SupplierRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+SupplierRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+tblOrderDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+tblOrderRow | class | nested public | no | 1 | 9 | 3 | 0 | 13 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+tblOrderRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+tblOrderRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Temp_Stock_RMDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_Stock_RMRow | class | nested public | no | 1 | 9 | 4 | 0 | 14 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_Stock_RMRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_Stock_RMRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Temp_Stock_StoreDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_Stock_StoreRow | class | nested public | no | 1 | 9 | 4 | 0 | 14 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_Stock_StoreRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_Stock_StoreRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Temp_StockDataTable | class | nested public | no | 11 | 39 | 8 | 4 | 62 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_StockRow | class | nested public | no | 1 | 21 | 8 | 0 | 30 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_StockRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Temp_StockRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+Voucher_OtherDetailsDataTable | class | nested public | no | 10 | 38 | 7 | 4 | 59 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Voucher_OtherDetailsRow | class | nested public | no | 1 | 17 | 7 | 0 | 25 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Voucher_OtherDetailsRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+Voucher_OtherDetailsRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+VoucherDataTable | class | nested public | no | 12 | 40 | 9 | 4 | 65 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+VoucherRow | class | nested public | no | 1 | 20 | 7 | 0 | 28 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+VoucherRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+VoucherRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+WalletDataTable | class | nested public | no | 6 | 34 | 3 | 4 | 47 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WalletRow | class | nested public | no | 1 | 3 | 1 | 0 | 5 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WalletRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WalletRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+WarehouseDataTable | class | nested public | no | 9 | 37 | 6 | 4 | 56 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WarehouseRow | class | nested public | no | 1 | 15 | 5 | 0 | 21 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WarehouseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WarehouseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+WarehouseTypeDataTable | class | nested public | no | 6 | 34 | 3 | 4 | 47 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WarehouseTypeRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WarehouseTypeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WarehouseTypeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+WorkPeriodEndDataTable | class | nested public | no | 7 | 35 | 4 | 4 | 50 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WorkPeriodEndRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WorkPeriodEndRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WorkPeriodEndRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet+WorkPeriodStartDataTable | class | nested public | no | 8 | 36 | 5 | 4 | 53 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WorkPeriodStartRow | class | nested public | no | 1 | 8 | 3 | 0 | 12 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WorkPeriodStartRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet.cs |
| RPOS_DBDataSet+WorkPeriodStartRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1 | class | public | no | 184 | 227 | 107 | 0 | 518 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ActivationDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ActivationRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ActivationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ActivationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+BankAccountLedgerDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankAccountLedgerRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankAccountLedgerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankAccountLedgerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+BankAccountRegistrationDataTable | class | nested public | no | 13 | 39 | 10 | 4 | 66 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankAccountRegistrationRow | class | nested public | no | 1 | 36 | 9 | 0 | 46 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankAccountRegistrationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankAccountRegistrationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+BankBranchDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankBranchRow | class | nested public | no | 1 | 28 | 8 | 0 | 37 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankBranchRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankBranchRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+BankDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+BankRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+CategoryDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CategoryRow | class | nested public | no | 1 | 28 | 8 | 0 | 37 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CategoryRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CategoryRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+ClockINDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ClockINRow | class | nested public | no | 1 | 14 | 4 | 0 | 19 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ClockINRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ClockINRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+ClockOUTDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ClockOUTRow | class | nested public | no | 1 | 13 | 4 | 0 | 18 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ClockOUTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ClockOUTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+CMISettingDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CMISettingRow | class | nested public | no | 1 | 15 | 4 | 0 | 20 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CMISettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CMISettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+CreditCustomerDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerLedgerDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerLedgerRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerLedgerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerLedgerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+CreditCustomerPaymentDataTable | class | nested public | no | 13 | 39 | 10 | 4 | 66 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerPaymentRow | class | nested public | no | 1 | 27 | 9 | 0 | 37 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerPaymentRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerPaymentRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+CreditCustomerRow | class | nested public | no | 1 | 35 | 9 | 0 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CreditCustomerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+CurrencyDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CurrencyRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CurrencyRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+CurrencyRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+DeletedInvoices_JoinDataTable | class | nested public | no | 10 | 36 | 7 | 4 | 57 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DeletedInvoices_JoinRow | class | nested public | no | 1 | 19 | 5 | 0 | 25 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DeletedInvoices_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DeletedInvoices_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+DeletedInvoicesDataTable | class | nested public | no | 15 | 41 | 12 | 4 | 72 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DeletedInvoicesRow | class | nested public | no | 1 | 39 | 10 | 0 | 50 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DeletedInvoicesRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DeletedInvoicesRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+DishDataTable | class | nested public | no | 17 | 43 | 14 | 4 | 78 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DishRow | class | nested public | no | 1 | 55 | 13 | 0 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DishRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+DishRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+EmailSettingDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+EmailSettingRow | class | nested public | no | 1 | 19 | 9 | 0 | 29 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+EmailSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+EmailSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+EmployeeRegistrationDataTable | class | nested public | no | 15 | 41 | 12 | 4 | 72 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+EmployeeRegistrationRow | class | nested public | no | 1 | 24 | 10 | 0 | 35 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+EmployeeRegistrationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+EmployeeRegistrationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+ExpenseDataTable | class | nested public | no | 7 | 33 | 4 | 4 | 48 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ExpenseRow | class | nested public | no | 1 | 8 | 3 | 0 | 12 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ExpenseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ExpenseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+ExpenseTypeDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ExpenseTypeRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ExpenseTypeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ExpenseTypeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+FundDepositDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+FundDepositRow | class | nested public | no | 1 | 25 | 7 | 0 | 33 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+FundDepositRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+FundDepositRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+FundTransferDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+FundTransferRow | class | nested public | no | 1 | 27 | 7 | 0 | 35 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+FundTransferRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+FundTransferRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+GiftCardDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+GiftCardRow | class | nested public | no | 1 | 15 | 4 | 0 | 20 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+GiftCardRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+GiftCardRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+GridGroupingDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+GridGroupingRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+GridGroupingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+GridGroupingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+HDCustomerDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HDCustomerRow | class | nested public | no | 1 | 15 | 4 | 0 | 20 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HDCustomerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HDCustomerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+HoldBillDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HoldBillRow | class | nested public | no | 1 | 35 | 9 | 0 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HoldBillRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HoldBillRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+HoldItemsDataTable | class | nested public | no | 24 | 50 | 21 | 4 | 99 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HoldItemsRow | class | nested public | no | 1 | 75 | 19 | 0 | 95 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HoldItemsRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HoldItemsRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+HotelDataTable | class | nested public | no | 22 | 48 | 19 | 4 | 93 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HotelRow | class | nested public | no | 1 | 67 | 17 | 0 | 85 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HotelRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+HotelRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+JournalDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+JournalRow | class | nested public | no | 1 | 23 | 6 | 0 | 30 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+JournalRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+JournalRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+KitchenDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+KitchenRow | class | nested public | no | 1 | 9 | 3 | 0 | 13 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+KitchenRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+KitchenRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+LedgerBookDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LedgerBookRow | class | nested public | no | 1 | 35 | 9 | 0 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LedgerBookRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LedgerBookRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+LogsDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LogsRow | class | nested public | no | 1 | 11 | 5 | 0 | 17 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LogsRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LogsRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+LoyaltyMemberDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltyMemberLedgerBookDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltyMemberLedgerBookRow | class | nested public | no | 1 | 19 | 8 | 0 | 28 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltyMemberLedgerBookRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltyMemberLedgerBookRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+LoyaltyMemberRow | class | nested public | no | 1 | 28 | 7 | 0 | 36 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltyMemberRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltyMemberRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+LoyaltySettingDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltySettingRow | class | nested public | no | 1 | 11 | 3 | 0 | 15 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltySettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+LoyaltySettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+MemberDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MemberLedgerDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MemberLedgerRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MemberLedgerRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MemberLedgerRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+MemberRow | class | nested public | no | 1 | 24 | 6 | 0 | 31 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MemberRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MemberRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+ModifiersDataTable | class | nested public | no | 10 | 36 | 7 | 4 | 57 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ModifiersRow | class | nested public | no | 1 | 21 | 6 | 0 | 28 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ModifiersRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ModifiersRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+MpesaSettingDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MpesaSettingRow | class | nested public | no | 1 | 27 | 7 | 0 | 35 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MpesaSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+MpesaSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+NotesMasterDataTable | class | nested public | no | 7 | 33 | 4 | 4 | 48 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+NotesMasterRow | class | nested public | no | 1 | 5 | 2 | 0 | 8 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+NotesMasterRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+NotesMasterRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+OtherSettingDataTable | class | nested public | no | 26 | 52 | 23 | 4 | 105 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+OtherSettingRow | class | nested public | no | 1 | 83 | 21 | 0 | 105 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+OtherSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+OtherSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Payment_WithdrawDataTable | class | nested public | no | 13 | 39 | 10 | 4 | 66 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Payment_WithdrawRow | class | nested public | no | 1 | 33 | 9 | 0 | 43 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Payment_WithdrawRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Payment_WithdrawRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PaymentDataTable | class | nested public | no | 13 | 39 | 10 | 4 | 66 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PaymentRow | class | nested public | no | 1 | 27 | 9 | 0 | 37 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PaymentRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PaymentRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Payroll_MBDataTable | class | nested public | no | 23 | 49 | 20 | 4 | 96 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Payroll_MBRow | class | nested public | no | 1 | 73 | 19 | 0 | 93 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Payroll_MBRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Payroll_MBRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PayrollDataTable | class | nested public | no | 23 | 49 | 20 | 4 | 96 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PayrollRow | class | nested public | no | 1 | 73 | 19 | 0 | 93 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PayrollRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PayrollRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PizzaMasterDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaMasterRow | class | nested public | no | 1 | 30 | 8 | 0 | 39 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaMasterRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaMasterRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PizzaModifierDataTable | class | nested public | no | 10 | 36 | 7 | 4 | 57 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaModifierRow | class | nested public | no | 1 | 21 | 6 | 0 | 28 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaModifierRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaModifierRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PizzaSizeDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaSizeRow | class | nested public | no | 1 | 5 | 1 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaSizeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaSizeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PizzaToppingDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaToppingRow | class | nested public | no | 1 | 25 | 7 | 0 | 33 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaToppingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PizzaToppingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PosGrouping1DataTable | class | nested public | no | 24 | 50 | 21 | 4 | 99 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosGrouping1Row | class | nested public | no | 1 | 75 | 19 | 0 | 95 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosGrouping1RowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosGrouping1RowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PosGroupingDataTable | class | nested public | no | 23 | 49 | 20 | 4 | 96 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosGroupingRow | class | nested public | no | 1 | 71 | 18 | 0 | 90 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosGroupingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosGroupingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PosPrinterSettingDataTable | class | nested public | no | 22 | 48 | 19 | 4 | 93 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosPrinterSettingRow | class | nested public | no | 1 | 67 | 17 | 0 | 85 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosPrinterSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PosPrinterSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Product_OpeningStockDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Product_OpeningStockRow | class | nested public | no | 1 | 21 | 8 | 0 | 30 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Product_OpeningStockRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Product_OpeningStockRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+ProductDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ProductRow | class | nested public | no | 1 | 41 | 11 | 0 | 53 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ProductRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+ProductRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PromotionDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PromotionRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PromotionRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PromotionRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Purchase_JoinDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Purchase_JoinRow | class | nested public | no | 1 | 29 | 12 | 0 | 42 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Purchase_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Purchase_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PurchaseDataTable | class | nested public | no | 24 | 50 | 21 | 4 | 99 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrder_JoinDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrder_JoinRow | class | nested public | no | 1 | 21 | 8 | 0 | 30 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrder_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrder_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PurchaseOrderDataTable | class | nested public | no | 15 | 41 | 12 | 4 | 72 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrderRow | class | nested public | no | 1 | 40 | 11 | 0 | 52 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrderRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseOrderRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+PurchaseRow | class | nested public | no | 1 | 48 | 20 | 0 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+PurchaseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+R_TableDataTable | class | nested public | no | 10 | 36 | 7 | 4 | 57 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+R_TableRow | class | nested public | no | 1 | 21 | 5 | 0 | 27 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+R_TableRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+R_TableRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Recipe_JoinDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Recipe_JoinRow | class | nested public | no | 1 | 23 | 8 | 0 | 32 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Recipe_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Recipe_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RecipeDataTable | class | nested public | no | 10 | 36 | 7 | 4 | 57 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RecipeRow | class | nested public | no | 1 | 16 | 6 | 0 | 23 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RecipeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RecipeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RegistrationDataTable | class | nested public | no | 17 | 43 | 14 | 4 | 78 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RegistrationRow | class | nested public | no | 1 | 51 | 12 | 0 | 64 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RegistrationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RegistrationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoEBDataTable | class | nested public | no | 30 | 56 | 27 | 4 | 117 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoEBRow | class | nested public | no | 1 | 98 | 26 | 0 | 125 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoEBRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoEBRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoHDDataTable | class | nested public | no | 30 | 56 | 27 | 4 | 117 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoHDRow | class | nested public | no | 1 | 98 | 27 | 0 | 126 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoHDRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoHDRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoKOTDataTable | class | nested public | no | 34 | 60 | 31 | 4 | 129 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoKOTRow | class | nested public | no | 1 | 118 | 30 | 0 | 149 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoTADataTable | class | nested public | no | 32 | 58 | 29 | 4 | 123 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoTARow | class | nested public | no | 1 | 106 | 28 | 0 | 135 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoTARowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_BillingInfoTARowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillEBDataTable | class | nested public | no | 25 | 51 | 22 | 4 | 102 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillEBRow | class | nested public | no | 1 | 81 | 21 | 0 | 103 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillEBRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillEBRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillHDDataTable | class | nested public | no | 24 | 50 | 21 | 4 | 99 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillHDRow | class | nested public | no | 1 | 77 | 20 | 0 | 98 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillHDRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillHDRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillKOTDataTable | class | nested public | no | 24 | 50 | 21 | 4 | 99 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillKOTRow | class | nested public | no | 1 | 79 | 21 | 0 | 101 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillTADataTable | class | nested public | no | 25 | 51 | 22 | 4 | 102 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillTARow | class | nested public | no | 1 | 81 | 21 | 0 | 103 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillTARowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductBillTARowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductKOTDataTable | class | nested public | no | 25 | 51 | 22 | 4 | 102 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductKOTRow | class | nested public | no | 1 | 81 | 21 | 0 | 103 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderedProductKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RestaurantPOS_OrderInfoKOTDataTable | class | nested public | no | 17 | 43 | 14 | 4 | 78 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderInfoKOTRow | class | nested public | no | 1 | 48 | 14 | 0 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderInfoKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RestaurantPOS_OrderInfoKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RM_Used_JoinDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RM_Used_JoinRow | class | nested public | no | 1 | 19 | 6 | 0 | 26 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RM_Used_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RM_Used_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RM_UsedDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RM_UsedRow | class | nested public | no | 1 | 12 | 3 | 0 | 16 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RM_UsedRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RM_UsedRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+RMCategoryDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RMCategoryRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RMCategoryRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+RMCategoryRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+SMSSettingDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SMSSettingRow | class | nested public | no | 1 | 9 | 4 | 0 | 14 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SMSSettingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SMSSettingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Stock_Store_JoinDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Stock_Store_JoinRow | class | nested public | no | 1 | 13 | 6 | 0 | 20 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Stock_Store_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Stock_Store_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Stock_StoreDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Stock_StoreRow | class | nested public | no | 1 | 8 | 3 | 0 | 12 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Stock_StoreRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Stock_StoreRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+StockAdjustment_MIDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_MIRow | class | nested public | no | 1 | 25 | 7 | 0 | 33 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_MIRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_MIRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+StockAdjustment_StoreDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_StoreRow | class | nested public | no | 1 | 25 | 7 | 0 | 33 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_StoreRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_StoreRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+StockAdjustment_WarehouseDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_WarehouseRow | class | nested public | no | 1 | 31 | 9 | 0 | 41 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_WarehouseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockAdjustment_WarehouseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+StockTransfer_JoinDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockTransfer_JoinRow | class | nested public | no | 1 | 21 | 9 | 0 | 31 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockTransfer_JoinRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockTransfer_JoinRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+StockTransferDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockTransferRow | class | nested public | no | 1 | 10 | 4 | 0 | 15 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockTransferRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+StockTransferRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+SupplierDataTable | class | nested public | no | 26 | 52 | 23 | 4 | 105 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SupplierLedgerBookDataTable | class | nested public | no | 13 | 39 | 10 | 4 | 66 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SupplierLedgerBookRow | class | nested public | no | 1 | 19 | 8 | 0 | 28 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SupplierLedgerBookRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SupplierLedgerBookRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+SupplierRow | class | nested public | no | 1 | 84 | 21 | 0 | 106 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SupplierRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+SupplierRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+TableLayoutDataTable | class | nested public | no | 13 | 39 | 10 | 4 | 66 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableLayoutRow | class | nested public | no | 1 | 33 | 9 | 0 | 43 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableLayoutRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableLayoutRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+TableMappingDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableMappingRow | class | nested public | no | 1 | 15 | 5 | 0 | 21 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableMappingRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableMappingRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+TableReservationDataTable | class | nested public | no | 14 | 40 | 11 | 4 | 69 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableReservationRow | class | nested public | no | 1 | 37 | 10 | 0 | 48 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableReservationRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TableReservationRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+tblOrderDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+tblOrderRow | class | nested public | no | 1 | 9 | 3 | 0 | 13 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+tblOrderRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+tblOrderRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Temp_Stock_RMDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_Stock_RMRow | class | nested public | no | 1 | 9 | 4 | 0 | 14 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_Stock_RMRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_Stock_RMRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Temp_Stock_StoreDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_Stock_StoreRow | class | nested public | no | 1 | 9 | 4 | 0 | 14 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_Stock_StoreRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_Stock_StoreRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Temp_StockDataTable | class | nested public | no | 11 | 37 | 8 | 4 | 60 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_StockRow | class | nested public | no | 1 | 21 | 8 | 0 | 30 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_StockRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Temp_StockRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+TempRestaurantPOS_BillingInfoKOTDataTable | class | nested public | no | 30 | 56 | 27 | 4 | 117 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TempRestaurantPOS_BillingInfoKOTRow | class | nested public | no | 1 | 102 | 26 | 0 | 129 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TempRestaurantPOS_BillingInfoKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TempRestaurantPOS_BillingInfoKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+TempRestaurantPOS_OrderedProductBillKOTDataTable | class | nested public | no | 24 | 50 | 21 | 4 | 99 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TempRestaurantPOS_OrderedProductBillKOTRow | class | nested public | no | 1 | 79 | 21 | 0 | 101 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TempRestaurantPOS_OrderedProductBillKOTRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+TempRestaurantPOS_OrderedProductBillKOTRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+UnitMasterDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+UnitMasterRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+UnitMasterRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+UnitMasterRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+UserRightsDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+UserRightsRow | class | nested public | no | 1 | 29 | 8 | 0 | 38 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+UserRightsRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+UserRightsRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+Voucher_OtherDetailsDataTable | class | nested public | no | 10 | 36 | 7 | 4 | 57 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Voucher_OtherDetailsRow | class | nested public | no | 1 | 17 | 7 | 0 | 25 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Voucher_OtherDetailsRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+Voucher_OtherDetailsRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+VoucherDataTable | class | nested public | no | 12 | 38 | 9 | 4 | 63 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+VoucherRow | class | nested public | no | 1 | 20 | 7 | 0 | 28 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+VoucherRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+VoucherRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+WalletDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WalletRow | class | nested public | no | 1 | 3 | 1 | 0 | 5 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WalletRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WalletRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+WarehouseDataTable | class | nested public | no | 9 | 35 | 6 | 4 | 54 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WarehouseRow | class | nested public | no | 1 | 16 | 5 | 0 | 22 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WarehouseRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WarehouseRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+WarehouseTypeDataTable | class | nested public | no | 6 | 32 | 3 | 4 | 45 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WarehouseTypeRow | class | nested public | no | 1 | 4 | 1 | 0 | 6 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WarehouseTypeRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WarehouseTypeRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+WorkPeriodEndDataTable | class | nested public | no | 7 | 33 | 4 | 4 | 48 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WorkPeriodEndRow | class | nested public | no | 1 | 7 | 3 | 0 | 11 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WorkPeriodEndRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WorkPeriodEndRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| RPOS_DBDataSet1+WorkPeriodStartDataTable | class | nested public | no | 8 | 34 | 5 | 4 | 51 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WorkPeriodStartRow | class | nested public | no | 1 | 8 | 3 | 0 | 12 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WorkPeriodStartRowChangeEvent | class | nested public | no | 2 | 3 | 2 | 0 | 7 | RPOS_DBDataSet1.cs |
| RPOS_DBDataSet1+WorkPeriodStartRowChangeEventHandler | delegate | nested public | no | 0 | 4 | 0 | 0 | 4 | (none) |
| rptBalanceReceipt | class | public | no | 1 | 18 | 12 | 0 | 31 | rptBalanceReceipt.cs |
| rptBalanceSheet | class | public | no | 1 | 19 | 13 | 0 | 33 | rptBalanceSheet.cs |
| rptBankAccountStatements | class | public | no | 1 | 16 | 10 | 0 | 27 | rptBankAccountStatements.cs |
| rptBankAccountStatements1 | class | public | no | 1 | 16 | 10 | 0 | 27 | rptBankAccountStatements1.cs |
| rptBarcodeLabelPrinting | class | public | no | 1 | 15 | 9 | 0 | 25 | rptBarcodeLabelPrinting.cs |
| rptCollectionsByDP | class | public | no | 1 | 18 | 12 | 0 | 31 | rptCollectionsByDP.cs |
| rptCollectionsByDP1 | class | public | no | 1 | 18 | 12 | 0 | 31 | rptCollectionsByDP1.cs |
| rptCollectionsByWaiter | class | public | no | 1 | 18 | 12 | 0 | 31 | rptCollectionsByWaiter.cs |
| rptCreditCustomerBalance | class | public | no | 1 | 14 | 8 | 0 | 23 | rptCreditCustomerBalance.cs |
| rptCreditCustomerLedger | class | public | no | 1 | 20 | 14 | 0 | 35 | rptCreditCustomerLedger.cs |
| rptCreditCustomerLedger1 | class | public | no | 1 | 19 | 13 | 0 | 33 | rptCreditCustomerLedger1.cs |
| rptCreditors | class | public | no | 1 | 15 | 9 | 0 | 25 | rptCreditors.cs |
| rptDeletedBills | class | public | no | 1 | 16 | 10 | 0 | 27 | rptDeletedBills.cs |
| rptDeletedItems | class | public | no | 1 | 16 | 10 | 0 | 27 | rptDeletedItems.cs |
| rptExpenses | class | public | no | 1 | 22 | 16 | 0 | 39 | rptExpenses.cs |
| rptFundDepositReceipt | class | public | no | 1 | 16 | 10 | 0 | 27 | rptFundDepositReceipt.cs |
| rptGeneralDayBook | class | public | no | 1 | 16 | 10 | 0 | 27 | rptGeneralDayBook.cs |
| rptGeneralLedger | class | public | no | 1 | 19 | 13 | 0 | 33 | rptGeneralLedger.cs |
| rptGiftCard | class | public | no | 1 | 14 | 8 | 0 | 23 | rptGiftCard.cs |
| rptInputTax | class | public | no | 1 | 16 | 10 | 0 | 27 | rptInputTax.cs |
| rptInvoiceSummary_CC | class | public | no | 1 | 18 | 12 | 0 | 31 | rptInvoiceSummary_CC.cs |
| rptLoyaltyCard | class | public | no | 1 | 15 | 9 | 0 | 25 | rptLoyaltyCard.cs |
| rptLoyaltyCardMemberBalance | class | public | no | 1 | 14 | 8 | 0 | 23 | rptLoyaltyCardMemberBalance.cs |
| rptLoyaltyCardMemberLedger | class | public | no | 1 | 21 | 15 | 0 | 37 | rptLoyaltyCardMemberLedger.cs |
| rptLoyaltyCardMemberLedger1 | class | public | no | 1 | 21 | 15 | 0 | 37 | rptLoyaltyCardMemberLedger1.cs |
| rptMemberBalance | class | public | no | 1 | 14 | 8 | 0 | 23 | rptMemberBalance.cs |
| rptMemberLedger | class | public | no | 1 | 21 | 15 | 0 | 37 | rptMemberLedger.cs |
| rptMemberLedger1 | class | public | no | 1 | 21 | 15 | 0 | 37 | rptMemberLedger1.cs |
| rptMenuItems | class | public | no | 1 | 18 | 12 | 0 | 31 | rptMenuItems.cs |
| rptPayment_WithdrawalReceipt | class | public | no | 1 | 16 | 10 | 0 | 27 | rptPayment_WithdrawalReceipt.cs |
| rptPaymentInvoice | class | public | no | 1 | 19 | 13 | 0 | 33 | rptPaymentInvoice.cs |
| rptPOS80mmByOperator | class | public | no | 1 | 21 | 15 | 0 | 37 | rptPOS80mmByOperator.cs |
| rptPOSA4 | class | public | no | 1 | 16 | 10 | 0 | 27 | rptPOSA4.cs |
| rptPOSA4ByOperator | class | public | no | 1 | 17 | 11 | 0 | 29 | rptPOSA4ByOperator.cs |
| rptPOSA4X | class | public | no | 1 | 16 | 10 | 0 | 27 | rptPOSA4X.cs |
| rptPurchase | class | public | no | 1 | 20 | 14 | 0 | 35 | rptPurchase.cs |
| rptPurchaseDayBook | class | public | no | 1 | 18 | 12 | 0 | 31 | rptPurchaseDayBook.cs |
| rptPurchaseOrder | class | public | no | 1 | 18 | 12 | 0 | 31 | rptPurchaseOrder.cs |
| rptReceipt | class | public | no | 1 | 19 | 13 | 0 | 33 | rptReceipt.cs |
| rptReceiptTP | class | public | no | 1 | 17 | 11 | 0 | 29 | rptReceiptTP.cs |
| rptRecipe | class | public | no | 1 | 20 | 14 | 0 | 35 | rptRecipe.cs |
| rptRestaurantPOS | class | public | no | 1 | 21 | 15 | 0 | 37 | rptRestaurantPOS.cs |
| rptRestaurantPOSEB | class | public | no | 1 | 21 | 15 | 0 | 37 | rptRestaurantPOSEB.cs |
| rptRestaurantPOSEBInvoice | class | public | no | 1 | 43 | 37 | 0 | 81 | rptRestaurantPOSEBInvoice.cs |
| rptRestaurantPOSEBInvoice_Kitchen | class | public | no | 1 | 22 | 16 | 0 | 39 | rptRestaurantPOSEBInvoice_Kitchen.cs |
| rptRestaurantPOSFinalBillKOTInvoice | class | public | no | 1 | 43 | 37 | 0 | 81 | rptRestaurantPOSFinalBillKOTInvoice.cs |
| rptRestaurantPOSHD | class | public | no | 1 | 21 | 15 | 0 | 37 | rptRestaurantPOSHD.cs |
| rptRestaurantPOSHDInvoice | class | public | no | 1 | 42 | 36 | 0 | 79 | rptRestaurantPOSHDInvoice.cs |
| rptRestaurantPOSHDInvoice_Kitchen | class | public | no | 1 | 22 | 16 | 0 | 39 | rptRestaurantPOSHDInvoice_Kitchen.cs |
| rptRestaurantPOSKOTInvoice_Kitchen | class | public | no | 1 | 23 | 17 | 0 | 41 | rptRestaurantPOSKOTInvoice_Kitchen.cs |
| rptRestaurantPOSTA | class | public | no | 1 | 21 | 15 | 0 | 37 | rptRestaurantPOSTA.cs |
| rptRestaurantPOSTAInvoice | class | public | no | 1 | 45 | 39 | 0 | 85 | rptRestaurantPOSTAInvoice.cs |
| rptRestaurantPOSTAInvoice_Kitchen | class | public | no | 1 | 22 | 16 | 0 | 39 | rptRestaurantPOSTAInvoice_Kitchen.cs |
| rptRestaurantPOSUpdatedKOTInvoice_Kitchen | class | public | no | 1 | 23 | 17 | 0 | 41 | rptRestaurantPOSUpdatedKOTInvoice_Kitchen.cs |
| rptRestaurantPOSVoidKOT_Kitchen | class | public | no | 1 | 20 | 14 | 0 | 35 | rptRestaurantPOSVoidKOT_Kitchen.cs |
| rptRPOS | class | public | no | 1 | 67 | 61 | 0 | 129 | rptRPOS.cs |
| rptRPOS1 | class | public | no | 1 | 67 | 61 | 0 | 129 | rptRPOS1.cs |
| rptRPOS2 | class | public | no | 1 | 67 | 61 | 0 | 129 | rptRPOS2.cs |
| rptRPOSByKitchen | class | public | no | 1 | 21 | 15 | 0 | 37 | rptRPOSByKitchen.cs |
| rptRPOSByMonth | class | public | no | 1 | 17 | 11 | 0 | 29 | rptRPOSByMonth.cs |
| rptRPOSCard | class | public | no | 1 | 15 | 9 | 0 | 25 | rptRPOSCard.cs |
| rptSalarySlip | class | public | no | 1 | 14 | 8 | 0 | 23 | rptSalarySlip.cs |
| rptSalarySlip_MB | class | public | no | 1 | 14 | 8 | 0 | 23 | rptSalarySlip_MB.cs |
| rptStockTransfer | class | public | no | 1 | 20 | 14 | 0 | 35 | rptStockTransfer.cs |
| rptStockTransferInvoice | class | public | no | 1 | 20 | 14 | 0 | 35 | rptStockTransferInvoice.cs |
| rptSupplierLedger | class | public | no | 1 | 23 | 17 | 0 | 41 | rptSupplierLedger.cs |
| rptTax | class | public | no | 1 | 16 | 10 | 0 | 27 | rptTax.cs |
| rptTrialBalance | class | public | no | 1 | 16 | 10 | 0 | 27 | rptTrialBalance.cs |
| rptVoidKOT | class | public | no | 1 | 18 | 12 | 0 | 31 | rptVoidKOT.cs |
| rptVoucher | class | public | no | 1 | 16 | 10 | 0 | 27 | rptVoucher.cs |
| rptWPByKitchen | class | public | no | 1 | 21 | 15 | 0 | 37 | rptWPByKitchen.cs |

### `RestaurantPOS14.EInvoicing`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| EInvoiceClient | class | public | no | 4 | 9 | 0 | 0 | 13 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;&gt;o__11 | class | nested private | yes | 14 | 0 | 0 | 0 | 14 | (none) |
| EInvoiceClient+&lt;&gt;o__6 | class | nested private | yes | 15 | 0 | 0 | 0 | 15 | (none) |
| EInvoiceClient+&lt;&gt;o__7 | class | nested private | yes | 15 | 0 | 0 | 0 | 15 | (none) |
| EInvoiceClient+&lt;&gt;o__8 | class | nested private | yes | 4 | 0 | 0 | 0 | 4 | (none) |
| EInvoiceClient+&lt;CancelAsync&gt;d__9 | struct | nested private | yes | 8 | 2 | 0 | 0 | 10 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;GetAccessTokenAsync&gt;d__5 | struct | nested private | yes | 5 | 2 | 0 | 0 | 7 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;GetStatusAsync&gt;d__8 | struct | nested private | yes | 7 | 2 | 0 | 0 | 9 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;GetSubmissionAsync&gt;d__11 | struct | nested private | yes | 6 | 2 | 0 | 0 | 8 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;ReplaceAsync&gt;d__10 | struct | nested private | yes | 7 | 2 | 0 | 0 | 9 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;SubmitAsync&gt;d__6 | struct | nested private | yes | 7 | 2 | 0 | 0 | 9 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceClient+&lt;SubmitAsync&gt;d__7 | struct | nested private | yes | 8 | 2 | 0 | 0 | 10 | EInvoiceIntegration\EInvoiceClient.cs |
| EInvoiceConfig | class | public | no | 4 | 10 | 4 | 0 | 18 | EInvoiceIntegration\EInvoiceConfig.cs |
| EInvoiceEnvironment | enum | public | no | 3 | 0 | 0 | 0 | 3 | (none) |
| EInvoiceQueue | class | public | no | 1 | 5 | 0 | 0 | 6 | EInvoiceIntegration\EInvoiceQueue.cs |
| EInvoiceQueue+&lt;DequeueAsync&gt;d__2 | struct | nested private | yes | 7 | 2 | 0 | 0 | 9 | EInvoiceIntegration\EInvoiceQueue.cs |
| EInvoiceQueue+&lt;MarkErrorAsync&gt;d__5 | struct | nested private | yes | 10 | 2 | 0 | 0 | 12 | EInvoiceIntegration\EInvoiceQueue.cs |
| EInvoiceQueue+&lt;MarkSubmittedAsync&gt;d__3 | struct | nested private | yes | 11 | 2 | 0 | 0 | 13 | EInvoiceIntegration\EInvoiceQueue.cs |
| EInvoiceQueue+&lt;MarkValidatedAsync&gt;d__4 | struct | nested private | yes | 8 | 2 | 0 | 0 | 10 | EInvoiceIntegration\EInvoiceQueue.cs |
| QueueItem | class | public | no | 10 | 21 | 10 | 0 | 41 | EInvoiceIntegration\EInvoiceQueue.cs |
| SubmissionResult | class | public | no | 9 | 19 | 9 | 0 | 37 | EInvoiceIntegration\EInvoiceClient.cs |

### `RestaurantPOS14.My`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| InternalXmlHelper | class | internal | yes | 0 | 12 | 0 | 0 | 12 | My\InternalXmlHelper.cs |
| InternalXmlHelper+RemoveNamespaceAttributesClosure | class | nested private | yes | 3 | 3 | 0 | 0 | 6 | My\InternalXmlHelper.cs |
| MyApplication | class | internal | no | 1 | 5 | 0 | 0 | 6 | My\MyApplication.cs |
| MyComputer | class | internal | no | 0 | 1 | 0 | 0 | 1 | My\MyComputer.cs |
| MyProject | class | internal | no | 5 | 7 | 5 | 0 | 17 | My\MyProject.cs |
| MyProject+MyForms | class | nested internal | no | 236 | 477 | 235 | 0 | 948 | My\MyProject.cs |
| MyProject+MyWebServices | class | nested internal | no | 0 | 7 | 0 | 0 | 7 | My\MyProject.cs |
| MyProject+ThreadSafeObjectProvider`1 | class | nested internal | no | 1 | 2 | 1 | 0 | 4 | My\MyProject.cs |
| MySettings | class | internal | yes | 3 | 5 | 2 | 0 | 10 | My\MySettings.cs<br>My\MySettings.Designer.cs |
| MySettingsProperty | class | internal | yes | 0 | 2 | 1 | 0 | 3 | My\MySettingsProperty.cs |

### `RestaurantPOS14.My.Resources`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| Resources | class | internal | yes | 2 | 123 | 121 | 0 | 246 | My\Resources\Resources.cs |

### `RestaurantPOS14.RPOS_DBDataSet1TableAdapters`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| ActivationTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ActivationTableAdapter.cs |
| BankAccountLedgerTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\BankAccountLedgerTableAdapter.cs |
| BankAccountRegistrationTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\BankAccountRegistrationTableAdapter.cs |
| BankBranchTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\BankBranchTableAdapter.cs |
| BankTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\BankTableAdapter.cs |
| CategoryTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\CategoryTableAdapter.cs |
| ClockINTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ClockINTableAdapter.cs |
| ClockOUTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ClockOUTTableAdapter.cs |
| CMISettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\CMISettingTableAdapter.cs |
| CreditCustomerLedgerTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\CreditCustomerLedgerTableAdapter.cs |
| CreditCustomerPaymentTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\CreditCustomerPaymentTableAdapter.cs |
| CreditCustomerTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\CreditCustomerTableAdapter.cs |
| CurrencyTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\CurrencyTableAdapter.cs |
| DeletedInvoices_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\DeletedInvoices_JoinTableAdapter.cs |
| DeletedInvoicesTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\DeletedInvoicesTableAdapter.cs |
| DishTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\DishTableAdapter.cs |
| EmailSettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\EmailSettingTableAdapter.cs |
| EmployeeRegistrationTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\EmployeeRegistrationTableAdapter.cs |
| ExpenseTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ExpenseTableAdapter.cs |
| ExpenseTypeTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ExpenseTypeTableAdapter.cs |
| FundDepositTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\FundDepositTableAdapter.cs |
| FundTransferTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\FundTransferTableAdapter.cs |
| GiftCardTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\GiftCardTableAdapter.cs |
| GridGroupingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\GridGroupingTableAdapter.cs |
| HDCustomerTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\HDCustomerTableAdapter.cs |
| HoldBillTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\HoldBillTableAdapter.cs |
| HoldItemsTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\HoldItemsTableAdapter.cs |
| HotelTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\HotelTableAdapter.cs |
| JournalTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\JournalTableAdapter.cs |
| KitchenTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\KitchenTableAdapter.cs |
| LedgerBookTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\LedgerBookTableAdapter.cs |
| LogsTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\LogsTableAdapter.cs |
| LoyaltyMemberLedgerBookTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\LoyaltyMemberLedgerBookTableAdapter.cs |
| LoyaltyMemberTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\LoyaltyMemberTableAdapter.cs |
| LoyaltySettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\LoyaltySettingTableAdapter.cs |
| MemberLedgerTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\MemberLedgerTableAdapter.cs |
| MemberTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\MemberTableAdapter.cs |
| ModifiersTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ModifiersTableAdapter.cs |
| MpesaSettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\MpesaSettingTableAdapter.cs |
| NotesMasterTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\NotesMasterTableAdapter.cs |
| OtherSettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\OtherSettingTableAdapter.cs |
| Payment_WithdrawTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Payment_WithdrawTableAdapter.cs |
| PaymentTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PaymentTableAdapter.cs |
| Payroll_MBTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Payroll_MBTableAdapter.cs |
| PayrollTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PayrollTableAdapter.cs |
| PizzaMasterTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PizzaMasterTableAdapter.cs |
| PizzaModifierTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PizzaModifierTableAdapter.cs |
| PizzaSizeTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PizzaSizeTableAdapter.cs |
| PizzaToppingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PizzaToppingTableAdapter.cs |
| PosGrouping1TableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PosGrouping1TableAdapter.cs |
| PosGroupingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PosGroupingTableAdapter.cs |
| PosPrinterSettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PosPrinterSettingTableAdapter.cs |
| Product_OpeningStockTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Product_OpeningStockTableAdapter.cs |
| ProductTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\ProductTableAdapter.cs |
| PromotionTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PromotionTableAdapter.cs |
| Purchase_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Purchase_JoinTableAdapter.cs |
| PurchaseOrder_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PurchaseOrder_JoinTableAdapter.cs |
| PurchaseOrderTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PurchaseOrderTableAdapter.cs |
| PurchaseTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\PurchaseTableAdapter.cs |
| R_TableTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\R_TableTableAdapter.cs |
| Recipe_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Recipe_JoinTableAdapter.cs |
| RecipeTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RecipeTableAdapter.cs |
| RegistrationTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RegistrationTableAdapter.cs |
| RestaurantPOS_BillingInfoEBTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoEBTableAdapter.cs |
| RestaurantPOS_BillingInfoHDTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoHDTableAdapter.cs |
| RestaurantPOS_BillingInfoKOTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoKOTTableAdapter.cs |
| RestaurantPOS_BillingInfoTATableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_BillingInfoTATableAdapter.cs |
| RestaurantPOS_OrderedProductBillEBTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillEBTableAdapter.cs |
| RestaurantPOS_OrderedProductBillHDTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillHDTableAdapter.cs |
| RestaurantPOS_OrderedProductBillKOTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillKOTTableAdapter.cs |
| RestaurantPOS_OrderedProductBillTATableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductBillTATableAdapter.cs |
| RestaurantPOS_OrderedProductKOTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderedProductKOTTableAdapter.cs |
| RestaurantPOS_OrderInfoKOTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RestaurantPOS_OrderInfoKOTTableAdapter.cs |
| RM_Used_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RM_Used_JoinTableAdapter.cs |
| RM_UsedTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RM_UsedTableAdapter.cs |
| RMCategoryTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\RMCategoryTableAdapter.cs |
| SMSSettingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\SMSSettingTableAdapter.cs |
| Stock_Store_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Stock_Store_JoinTableAdapter.cs |
| Stock_StoreTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Stock_StoreTableAdapter.cs |
| StockAdjustment_MITableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\StockAdjustment_MITableAdapter.cs |
| StockAdjustment_StoreTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\StockAdjustment_StoreTableAdapter.cs |
| StockAdjustment_WarehouseTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\StockAdjustment_WarehouseTableAdapter.cs |
| StockTransfer_JoinTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\StockTransfer_JoinTableAdapter.cs |
| StockTransferTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\StockTransferTableAdapter.cs |
| SupplierLedgerBookTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\SupplierLedgerBookTableAdapter.cs |
| SupplierTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\SupplierTableAdapter.cs |
| TableAdapterManager | class | public | no | 108 | 225 | 108 | 0 | 441 | RPOS_DBDataSet1TableAdapters\TableAdapterManager.cs |
| TableAdapterManager+SelfReferenceComparer | class | nested private | no | 2 | 4 | 0 | 0 | 6 | RPOS_DBDataSet1TableAdapters\TableAdapterManager.cs |
| TableAdapterManager+UpdateOrderOption | enum | nested public | no | 3 | 0 | 0 | 0 | 3 | (none) |
| TableLayoutTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\TableLayoutTableAdapter.cs |
| TableMappingTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\TableMappingTableAdapter.cs |
| TableReservationTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\TableReservationTableAdapter.cs |
| tblOrderTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\tblOrderTableAdapter.cs |
| Temp_Stock_RMTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Temp_Stock_RMTableAdapter.cs |
| Temp_Stock_StoreTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Temp_Stock_StoreTableAdapter.cs |
| Temp_StockTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Temp_StockTableAdapter.cs |
| TempRestaurantPOS_BillingInfoKOTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\TempRestaurantPOS_BillingInfoKOTTableAdapter.cs |
| TempRestaurantPOS_OrderedProductBillKOTTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\TempRestaurantPOS_OrderedProductBillKOTTableAdapter.cs |
| UnitMasterTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\UnitMasterTableAdapter.cs |
| UserRightsTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\UserRightsTableAdapter.cs |
| Voucher_OtherDetailsTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\Voucher_OtherDetailsTableAdapter.cs |
| VoucherTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\VoucherTableAdapter.cs |
| WalletTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\WalletTableAdapter.cs |
| WarehouseTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\WarehouseTableAdapter.cs |
| WarehouseTypeTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\WarehouseTypeTableAdapter.cs |
| WorkPeriodEndTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\WorkPeriodEndTableAdapter.cs |
| WorkPeriodStartTableAdapter | class | public | no | 6 | 26 | 6 | 0 | 38 | RPOS_DBDataSet1TableAdapters\WorkPeriodStartTableAdapter.cs |

### `RestaurantPOS14.RPOS_DBDataSetTableAdapters`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| ActivationTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\ActivationTableAdapter.cs |
| CategoryTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\CategoryTableAdapter.cs |
| CreditCustomerLedgerTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\CreditCustomerLedgerTableAdapter.cs |
| CreditCustomerPaymentTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\CreditCustomerPaymentTableAdapter.cs |
| CreditCustomerTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\CreditCustomerTableAdapter.cs |
| CurrencyTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\CurrencyTableAdapter.cs |
| DishTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\DishTableAdapter.cs |
| EmailSettingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\EmailSettingTableAdapter.cs |
| EmployeeRegistrationTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\EmployeeRegistrationTableAdapter.cs |
| ExpenseTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\ExpenseTableAdapter.cs |
| ExpenseTypeTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\ExpenseTypeTableAdapter.cs |
| GridGroupingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\GridGroupingTableAdapter.cs |
| HDCustomerTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\HDCustomerTableAdapter.cs |
| HotelTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\HotelTableAdapter.cs |
| KitchenTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\KitchenTableAdapter.cs |
| LedgerBookTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\LedgerBookTableAdapter.cs |
| LogsTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\LogsTableAdapter.cs |
| LoyaltyMemberLedgerBookTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\LoyaltyMemberLedgerBookTableAdapter.cs |
| LoyaltyMemberTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\LoyaltyMemberTableAdapter.cs |
| LoyaltySettingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\LoyaltySettingTableAdapter.cs |
| MemberLedgerTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\MemberLedgerTableAdapter.cs |
| MemberTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\MemberTableAdapter.cs |
| NotesMasterTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\NotesMasterTableAdapter.cs |
| OtherSettingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\OtherSettingTableAdapter.cs |
| PaymentTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PaymentTableAdapter.cs |
| PizzaMasterTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PizzaMasterTableAdapter.cs |
| PizzaSizeTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PizzaSizeTableAdapter.cs |
| PizzaToppingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PizzaToppingTableAdapter.cs |
| PosGrouping1TableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PosGrouping1TableAdapter.cs |
| PosGroupingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PosGroupingTableAdapter.cs |
| PosPrinterSettingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PosPrinterSettingTableAdapter.cs |
| Product_OpeningStockTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Product_OpeningStockTableAdapter.cs |
| ProductTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\ProductTableAdapter.cs |
| Purchase_JoinTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Purchase_JoinTableAdapter.cs |
| PurchaseTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\PurchaseTableAdapter.cs |
| R_TableTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\R_TableTableAdapter.cs |
| Recipe_JoinTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Recipe_JoinTableAdapter.cs |
| RecipeTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RecipeTableAdapter.cs |
| RegistrationTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RegistrationTableAdapter.cs |
| RestaurantPOS_BillingInfoEBTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoEBTableAdapter.cs |
| RestaurantPOS_BillingInfoHDTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoHDTableAdapter.cs |
| RestaurantPOS_BillingInfoKOTTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoKOTTableAdapter.cs |
| RestaurantPOS_BillingInfoTATableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_BillingInfoTATableAdapter.cs |
| RestaurantPOS_OrderedProductBillEBTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillEBTableAdapter.cs |
| RestaurantPOS_OrderedProductBillHDTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillHDTableAdapter.cs |
| RestaurantPOS_OrderedProductBillKOTTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillKOTTableAdapter.cs |
| RestaurantPOS_OrderedProductBillTATableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductBillTATableAdapter.cs |
| RestaurantPOS_OrderedProductKOTTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderedProductKOTTableAdapter.cs |
| RestaurantPOS_OrderInfoKOTTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\RestaurantPOS_OrderInfoKOTTableAdapter.cs |
| SMSSettingTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\SMSSettingTableAdapter.cs |
| Stock_Store_JoinTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Stock_Store_JoinTableAdapter.cs |
| Stock_StoreTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Stock_StoreTableAdapter.cs |
| StockTransfer_JoinTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\StockTransfer_JoinTableAdapter.cs |
| StockTransferTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\StockTransferTableAdapter.cs |
| SupplierLedgerBookTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\SupplierLedgerBookTableAdapter.cs |
| SupplierTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\SupplierTableAdapter.cs |
| tblOrderTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\tblOrderTableAdapter.cs |
| Temp_Stock_RMTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Temp_Stock_RMTableAdapter.cs |
| Temp_Stock_StoreTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Temp_Stock_StoreTableAdapter.cs |
| Temp_StockTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Temp_StockTableAdapter.cs |
| Voucher_OtherDetailsTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\Voucher_OtherDetailsTableAdapter.cs |
| VoucherTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\VoucherTableAdapter.cs |
| WalletTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\WalletTableAdapter.cs |
| WarehouseTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\WarehouseTableAdapter.cs |
| WarehouseTypeTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\WarehouseTypeTableAdapter.cs |
| WorkPeriodEndTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\WorkPeriodEndTableAdapter.cs |
| WorkPeriodStartTableAdapter | class | public | no | 5 | 24 | 5 | 0 | 34 | RPOS_DBDataSetTableAdapters\WorkPeriodStartTableAdapter.cs |

### `System.Runtime.CompilerServices`

| Type | Kind | Visibility | Generated | Fields | Methods | Properties | Events | Total declared members | PDB document(s) |
|---|---|---|---|---:|---:|---:|---:|---:|---|
| RefSafetyRulesAttribute | class | internal | yes | 1 | 1 | 0 | 0 | 2 | System\Runtime\CompilerServices\RefSafetyRulesAttribute.cs |

## Embedded resource inventory

| # | Logical name | Kind | Bytes | SHA-256 of payload |
|---:|---|---|---:|---|
| 1 | RestaurantPOS14.exe.licenses | License resource | 279 | 68201e551f3cd17617e4fc9703149eec2add15372bd4b9624ef8487ef2a4275e |
| 2 | RestaurantPOS14.frmAbout.resources | .NET resources | 180837 | af34bc1d10f80872e63057e5478ce8b815b07d41a31a65e9a07c4370da390bdf |
| 3 | RestaurantPOS14.frmAccountingReport.resources | .NET resources | 232342 | f51c27771692b0aa4d6a9a8ebec13d0b8ae5aeab6db9af16c8f5372da280005d |
| 4 | RestaurantPOS14.frmAddFunds.resources | .NET resources | 188125 | de982ecdf9490a4ae30cf2546d1ba5cb06231ce1c511bf4ebb5d293923212a3f |
| 5 | RestaurantPOS14.frmAddFundsRecord.resources | .NET resources | 178388 | 5180a575c087a010a56a8f8e160959277d8627cdd2921a3275989bd1cf64b268 |
| 6 | RestaurantPOS14.frmAssignedTablesList_Waiter.resources | .NET resources | 170819 | 8b0d3a0e33385aa7f51cc80ac4a311aa228cec4928b81393cb163e060906eaa8 |
| 7 | RestaurantPOS14.frmAttendance.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 8 | RestaurantPOS14.frmAvailableTables.resources | .NET resources | 171723 | ed7b62370b4b506f9fe623270aa947d6959b24acdab5efb83ba7d5eb7a39c8c1 |
| 9 | RestaurantPOS14.frmBackOffice.resources | .NET resources | 847988 | fdb2a1f182f2df25d32ccb1081af905c021477006720bd3a5a6dd4ad0d8b287c |
| 10 | RestaurantPOS14.frmBank.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 11 | RestaurantPOS14.frmBankAccountRegistration.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 12 | RestaurantPOS14.frmBankAccountStatements.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 13 | RestaurantPOS14.frmBankReconciliation.resources | .NET resources | 34616 | 85648b5e362a54e30e66b4a3c03af895d475bc52c0548d74395b7b83a42e53ba |
| 14 | RestaurantPOS14.frmBarcodeLabelPrinting.resources | .NET resources | 165925 | bf9a61827504352dab2d137e40cda6d7afef78855582f1ae9ce6db5f42c221ec |
| 15 | RestaurantPOS14.frmBillSplit.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 16 | RestaurantPOS14.frmBranchMaster_Bank.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 17 | RestaurantPOS14.frmCallerID.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 18 | RestaurantPOS14.frmCards_POS.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 19 | RestaurantPOS14.frmCards.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 20 | RestaurantPOS14.frmCategoriesExportImport.resources | .NET resources | 179448 | 1844d7ec5f7ac00613169eace515387c1dc2b314cb90351a36d00f345e2dd185 |
| 21 | RestaurantPOS14.frmChangeQty.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 22 | RestaurantPOS14.frmChangeRate.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 23 | RestaurantPOS14.frmClockINandOUT.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 24 | RestaurantPOS14.frmCMISetting.resources | .NET resources | 175033 | ff1d5bc7f8ad003605eb4e6389c0b2b70690d3167ca6b1ea677920b427c2ab24 |
| 25 | RestaurantPOS14.frmCreditCustomer.resources | .NET resources | 191159 | 2f6a641fc4754c8d51236feef296ca1f12ca8ed819bef81e07550fddb1dc8feb |
| 26 | RestaurantPOS14.frmCreditCustomerBalance.resources | .NET resources | 175304 | cb339d0ae8de36ad6c1ebd9d5a290f6f96822abae8c419c9fbedab28054c8514 |
| 27 | RestaurantPOS14.frmCreditCustomerLedger.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 28 | RestaurantPOS14.frmCreditCustomerReceipt.resources | .NET resources | 179332 | 210b284dc3130fb181d3d4a3ccf4ea76954322c1dd6c26c598c36b84b34a90ba |
| 29 | RestaurantPOS14.frmCreditCustomerReceiptRecord.resources | .NET resources | 171334 | f704b6c6c144c5ff518a72fc8f8224a2b0c3ecb41ad720af40e85812d4bb2f08 |
| 30 | RestaurantPOS14.frmCreditCustomerRegistration.resources | .NET resources | 175287 | 882fb156ec4abdf4a0daa9f037480638da87c8e2d7d22471f01b440220606b8e |
| 31 | RestaurantPOS14.frmCreditCustomersList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 32 | RestaurantPOS14.frmCurrency.resources | .NET resources | 80358 | 8fe1759c0cd32464c7f8776f77a5c970dcbd67897d4bda73268c1956da3fa6a2 |
| 33 | RestaurantPOS14.frmCustomDialogWS.resources | .NET resources | 42584 | 81874365282bd61cfc36d823a9ead600c992c603f0eed99ad73a560239b29555 |
| 34 | RestaurantPOS14.frmCustomer.resources | .NET resources | 183152 | 0670d68c3d4e3d8dc4f9533521aa91b81805193751d9d525adcecf5222771b7e |
| 35 | RestaurantPOS14.frmCustomersExportImport.resources | .NET resources | 177047 | f1af3f2bdb26539f9e9055a1f85a9718a11b571849a05716cedcd892a2065dc4 |
| 36 | RestaurantPOS14.frmCustomersRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 37 | RestaurantPOS14.frmDatabase.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 38 | RestaurantPOS14.frmDeliveryPersonLedger.resources | .NET resources | 13527 | 6b82d9651e96ef919e5b840b669277eaa7632af606aba8ece665dd85cf96499f |
| 39 | RestaurantPOS14.frmDeliveryPersonRecord.resources | .NET resources | 176310 | c44c7082561594d519b8e6169dd061d0363667b5bc41a643b264d9fa8fc8ce1b |
| 40 | RestaurantPOS14.frmEmailSetting.resources | .NET resources | 179697 | 34d4d6457b5af68c1d112a7164b5ab1170edf6467edbeb8b9d9e3e6bba4cb185 |
| 41 | RestaurantPOS14.frmEmployeeRegistration.resources | .NET resources | 189206 | cbeb41b988dcd005be141a281f06d35f4c4438b7e62639f6e22ee5e86771c46c |
| 42 | RestaurantPOS14.frmEmployeeSession.resources | .NET resources | 179226 | 0a7b6ea938b01f4667593f14d0fbf7b8b49ee604d056bc5ff9baf1819a70319e |
| 43 | RestaurantPOS14.frmEmployeesRecord.resources | .NET resources | 176310 | c44c7082561594d519b8e6169dd061d0363667b5bc41a643b264d9fa8fc8ce1b |
| 44 | RestaurantPOS14.frmEnterQty.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 45 | RestaurantPOS14.frmEnterQtyX.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 46 | RestaurantPOS14.frmExecuteQuery.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 47 | RestaurantPOS14.frmExpense.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 48 | RestaurantPOS14.frmExpenseType.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 49 | RestaurantPOS14.frmExpiredProductsRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 50 | RestaurantPOS14.frmFreeToppingsList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 51 | RestaurantPOS14.frmFrontOffice_Report.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 52 | RestaurantPOS14.frmFrontOffice.resources | .NET resources | 233811 | a9f5135bf12f25529d5b2d089ff08b358d7e7f8d7080e360e90097b3c89bb76e |
| 53 | RestaurantPOS14.frmFundDeposit.resources | .NET resources | 178213 | eb660d561f3261971da7e7100ca2f26d47c50cc7fc9c9ec452a4a4489fee6df3 |
| 54 | RestaurantPOS14.frmFundTransfer.resources | .NET resources | 175784 | 2c042e6403328ce8998806e2eca98beed4b67ffdcaa862f575c33945ea19cc3f |
| 55 | RestaurantPOS14.frmGeneralLedger.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 56 | RestaurantPOS14.frmGiftCard.resources | .NET resources | 182122 | 81723f7fdbf920d4a541722a7ee8dbb27a1c29f0a4b60016d39ce4105be46fe2 |
| 57 | RestaurantPOS14.frmGiftCardRecord.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 58 | RestaurantPOS14.frmHDStatus.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 59 | RestaurantPOS14.frmHoldBills.resources | .NET resources | 165845 | 58cfdfa4feb22876a8e19e883b582e2e6b95449186b2033cd1b3e7b72135a6c6 |
| 60 | RestaurantPOS14.frmHoldBillsHD.resources | .NET resources | 165845 | 58cfdfa4feb22876a8e19e883b582e2e6b95449186b2033cd1b3e7b72135a6c6 |
| 61 | RestaurantPOS14.frmHoldDineInKOTs.resources | .NET resources | 165845 | 58cfdfa4feb22876a8e19e883b582e2e6b95449186b2033cd1b3e7b72135a6c6 |
| 62 | RestaurantPOS14.frmHomeDelivery.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 63 | RestaurantPOS14.frmImportExportExcel_Products.resources | .NET resources | 179651 | b41694dc7e1ab467a6fb3d07113818a73e42ecb7dbb86b6df58d5555bff0441d |
| 64 | RestaurantPOS14.frmImportExportExcel_Supplier.resources | .NET resources | 179651 | b41694dc7e1ab467a6fb3d07113818a73e42ecb7dbb86b6df58d5555bff0441d |
| 65 | RestaurantPOS14.frmItemsTransfer.resources | .NET resources | 170821 | 570be0dbbbe2a31462967d89cbcb635e5da596f5c93bd946f2004fa7004da8d7 |
| 66 | RestaurantPOS14.frmJournalEntries.resources | .NET resources | 173944 | cfba5b7a4ed28e6f7cd62f71d4ae96152d274f54de063491007c803cba209e87 |
| 67 | RestaurantPOS14.frmKDS.resources | .NET resources | 170954 | 4216ed4abf31b52922c44a12895a779ace54725f56d4876244dd76e6d9d44cdd |
| 68 | RestaurantPOS14.frmKitchen_Section.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 69 | RestaurantPOS14.frmLogin.resources | .NET resources | 554091 | 241acb72bbf9055802d01e1ec0d067f4dfc594f43725d13769edafa08ae4b841 |
| 70 | RestaurantPOS14.frmLogs.resources | .NET resources | 183226 | afc28636b7e99dc081e695f62eacb3cd70b76221006a6af8d9e0d5aa9952c83c |
| 71 | RestaurantPOS14.frmLowStockRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 72 | RestaurantPOS14.frmLoyaltyCard.resources | .NET resources | 8812 | 9aa60c13ca011bbb3fcfe93c96e593a97b46ff153711efafa405ecc977fb3b4b |
| 73 | RestaurantPOS14.frmLoyaltyCardMemberLedger.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 74 | RestaurantPOS14.frmLoyaltyCardMemberList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 75 | RestaurantPOS14.frmLoyaltyCardMemberPoints.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 76 | RestaurantPOS14.frmLoyaltyMember.resources | .NET resources | 182094 | 6016f428cf7f3f31005baf49bb440618c81415a8f47a304708cb307712751ffe |
| 77 | RestaurantPOS14.frmLoyaltySetting.resources | .NET resources | 247400 | 8a7e7f247fb594ef9db4e24b63552d6bee3f0d43d2ca9c932769c56163af1382 |
| 78 | RestaurantPOS14.frmMarketingTools.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 79 | RestaurantPOS14.frmMember.resources | .NET resources | 182094 | 6016f428cf7f3f31005baf49bb440618c81415a8f47a304708cb307712751ffe |
| 80 | RestaurantPOS14.frmMemberBalance.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 81 | RestaurantPOS14.frmMemberLedger.resources | .NET resources | 13527 | 6b82d9651e96ef919e5b840b669277eaa7632af606aba8ece665dd85cf96499f |
| 82 | RestaurantPOS14.frmMemberList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 83 | RestaurantPOS14.frmMenuItem.resources | .NET resources | 192800 | 66fb0c2232ec4bdfbb9fb1cdb2edbb84d65461628bb48c2de17e301200e2515d |
| 84 | RestaurantPOS14.frmMenuItemsCategory.resources | .NET resources | 183152 | 0670d68c3d4e3d8dc4f9533521aa91b81805193751d9d525adcecf5222771b7e |
| 85 | RestaurantPOS14.frmMenuItemsExportImport.resources | .NET resources | 179448 | 1844d7ec5f7ac00613169eace515387c1dc2b314cb90351a36d00f345e2dd185 |
| 86 | RestaurantPOS14.frmMenuItemsList.resources | .NET resources | 165845 | 58cfdfa4feb22876a8e19e883b582e2e6b95449186b2033cd1b3e7b72135a6c6 |
| 87 | RestaurantPOS14.frmMenuItemsModifiers.resources | .NET resources | 183152 | 0670d68c3d4e3d8dc4f9533521aa91b81805193751d9d525adcecf5222771b7e |
| 88 | RestaurantPOS14.frmModifiersExportImport.resources | .NET resources | 177047 | f1af3f2bdb26539f9e9055a1f85a9718a11b571849a05716cedcd892a2065dc4 |
| 89 | RestaurantPOS14.frmModifiersList_AutoPopUp.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 90 | RestaurantPOS14.frmModifiersList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 91 | RestaurantPOS14.frmMpesaSetting.resources | .NET resources | 174643 | b2c87afc7eec490fbbbd9b587a3fe2ea9ef282a855e3a4dc2e1675decb1bc77e |
| 92 | RestaurantPOS14.frmNotes.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 93 | RestaurantPOS14.frmNotes1.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 94 | RestaurantPOS14.frmNotesMaster.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 95 | RestaurantPOS14.frmOnscreenKeyboard.resources | .NET resources | 172213 | 1555bf5b4943289d2bc50c2e954383e0d5e33a7f68122c6ec8ca21e94a9f0295 |
| 96 | RestaurantPOS14.frmOpenItems.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 97 | RestaurantPOS14.frmOpenTicketsRecord.resources | .NET resources | 175784 | 2c042e6403328ce8998806e2eca98beed4b67ffdcaa862f575c33945ea19cc3f |
| 98 | RestaurantPOS14.frmOption.resources | .NET resources | 199862 | ec1f2f4dc009501bad4bb4273135a00fcb03b3450358088b714d197e63e64f1e |
| 99 | RestaurantPOS14.frmOrderedItemDetails.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 100 | RestaurantPOS14.frmOthersSetting.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 101 | RestaurantPOS14.frmPayment_Withdrawal.resources | .NET resources | 178213 | eb660d561f3261971da7e7100ca2f26d47c50cc7fc9c9ec452a4a4489fee6df3 |
| 102 | RestaurantPOS14.frmPayment.resources | .NET resources | 179332 | 210b284dc3130fb181d3d4a3ccf4ea76954322c1dd6c26c598c36b84b34a90ba |
| 103 | RestaurantPOS14.frmPaymentRecord.resources | .NET resources | 169727 | 856a5f9b77bdba39dfb3188def60f77de4cba2f9ba8d9b81c7e3bfc2b945b0f0 |
| 104 | RestaurantPOS14.frmPayroll_HB.resources | .NET resources | 249358 | d441bfa0d577dbb87eab44a451a83241c8569d31cdaf3c14f0f5dfa09353a90e |
| 105 | RestaurantPOS14.frmPayroll_MB.resources | .NET resources | 249358 | d441bfa0d577dbb87eab44a451a83241c8569d31cdaf3c14f0f5dfa09353a90e |
| 106 | RestaurantPOS14.frmPayroll_MBRecord.resources | .NET resources | 21867 | 0b3e04baf24322b94a304b95d9e23fc77eb1d1720067946b9a863db581a51577 |
| 107 | RestaurantPOS14.frmPayroll.resources | .NET resources | 1024 | bc54d9c95c9f0c321ac2127550fdc8af72146a0ef8395279c0a19805709a5f99 |
| 108 | RestaurantPOS14.frmPayrollRecord_HB.resources | .NET resources | 21867 | 0b3e04baf24322b94a304b95d9e23fc77eb1d1720067946b9a863db581a51577 |
| 109 | RestaurantPOS14.frmPizza.resources | .NET resources | 18580 | 8db7dc2b79e6ba26497e78d24e57e0ff8eddfa570d7902b4b247ecad855fefd3 |
| 110 | RestaurantPOS14.frmPizzaMaster.resources | .NET resources | 183152 | 0670d68c3d4e3d8dc4f9533521aa91b81805193751d9d525adcecf5222771b7e |
| 111 | RestaurantPOS14.frmPizzaModifiers.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 112 | RestaurantPOS14.frmPizzaModifiersList_AutoPopUp.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 113 | RestaurantPOS14.frmPizzaModifiersList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 114 | RestaurantPOS14.frmPizzaPOS.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 115 | RestaurantPOS14.frmPizzasExportImport.resources | .NET resources | 179448 | 1844d7ec5f7ac00613169eace515387c1dc2b314cb90351a36d00f345e2dd185 |
| 116 | RestaurantPOS14.frmPizzaSize.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 117 | RestaurantPOS14.frmPizzaToppings.resources | .NET resources | 183152 | 0670d68c3d4e3d8dc4f9533521aa91b81805193751d9d525adcecf5222771b7e |
| 118 | RestaurantPOS14.frmPizzaToppingsExportImport.resources | .NET resources | 177047 | f1af3f2bdb26539f9e9055a1f85a9718a11b571849a05716cedcd892a2065dc4 |
| 119 | RestaurantPOS14.frmPO_CRViewer.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 120 | RestaurantPOS14.frmPOS.resources | .NET resources | 201266 | 963323ea7edd987993d1428bf402591d61f6d25fd9bee3db9959747a209a0fad |
| 121 | RestaurantPOS14.frmPOSRecord.resources | .NET resources | 169503 | 51c3f66b0ebb61e6647cff3ec2bedc0f7d94a963ead33c8731ffe539e9d63d89 |
| 122 | RestaurantPOS14.frmPOSReport_CRViewer.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 123 | RestaurantPOS14.frmPOSReport_CRViewer1.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 124 | RestaurantPOS14.frmPOSReport.resources | .NET resources | 209224 | 6ac83b5218d815842d6fc6f2055bce3568415b23af2b1780b24389cc891a30c2 |
| 125 | RestaurantPOS14.frmPrinterStatus.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 126 | RestaurantPOS14.frmPrintLoyaltyCard.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 127 | RestaurantPOS14.frmPrintVIPMemberCard.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 128 | RestaurantPOS14.frmProduct.resources | .NET resources | 189348 | be5b908eb359a33e48a75cf15b5fef6242a428c9dc8cc463002313327925d2f0 |
| 129 | RestaurantPOS14.frmProductRecord.resources | .NET resources | 176310 | c44c7082561594d519b8e6169dd061d0363667b5bc41a643b264d9fa8fc8ce1b |
| 130 | RestaurantPOS14.frmPromotion.resources | .NET resources | 185569 | c9c2e88de51de1f6b906667acea99a6b3e1cd366910f0060caf35fa4f9057e99 |
| 131 | RestaurantPOS14.frmPurchaseEntry.resources | .NET resources | 187174 | 9c3b0dadd1603a6ffbb78cfe951f36c1f9cfd82b34c2dc04bfd7a1d77425b683 |
| 132 | RestaurantPOS14.frmPurchaseOrder.resources | .NET resources | 186473 | a757a5cc0e55b7a1fa88e77c3586167fec7646c813940499b5da8c7ca5e88bc5 |
| 133 | RestaurantPOS14.frmPurchaseOrderRecord.resources | .NET resources | 169503 | 51c3f66b0ebb61e6647cff3ec2bedc0f7d94a963ead33c8731ffe539e9d63d89 |
| 134 | RestaurantPOS14.frmPurchaseRecord.resources | .NET resources | 176310 | c44c7082561594d519b8e6169dd061d0363667b5bc41a643b264d9fa8fc8ce1b |
| 135 | RestaurantPOS14.frmRawMaterialsCategory.resources | .NET resources | 180649 | 63cfc96370c04332326b63403a9016e958f1adedd34724ac3097b083f6474a87 |
| 136 | RestaurantPOS14.frmRawMaterialsUsed.resources | .NET resources | 175784 | 2c042e6403328ce8998806e2eca98beed4b67ffdcaa862f575c33945ea19cc3f |
| 137 | RestaurantPOS14.frmRecipe.resources | .NET resources | 37663 | 94128f29ffa524ad1dd97e7136c99a0ef7d8d0814046f6c5e7eb8f2fb4e44377 |
| 138 | RestaurantPOS14.frmRecipeRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 139 | RestaurantPOS14.frmRecoveryPIN.resources | .NET resources | 93776 | 840d84f6c8314a0dc7494670fd45bca144e8fd5d3f9ad9cec059652fd3ee9d11 |
| 140 | RestaurantPOS14.frmRefundMoney.resources | .NET resources | 188125 | de982ecdf9490a4ae30cf2546d1ba5cb06231ce1c511bf4ebb5d293923212a3f |
| 141 | RestaurantPOS14.frmRefundMoneyRecord.resources | .NET resources | 178388 | 5180a575c087a010a56a8f8e160959277d8627cdd2921a3275989bd1cf64b268 |
| 142 | RestaurantPOS14.frmRegistration.resources | .NET resources | 175287 | 882fb156ec4abdf4a0daa9f037480638da87c8e2d7d22471f01b440220606b8e |
| 143 | RestaurantPOS14.frmReport.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 144 | RestaurantPOS14.frmRestaurantMaster.resources | .NET resources | 189468 | f4e397516ad73161cfa007832f827d60c1fb071f6d54e541dcba0b0ec4e2eb1c |
| 145 | RestaurantPOS14.frmRestaurantPOSEBRecord_Unpaid.resources | .NET resources | 178301 | bc2c0ae0d78bd06e1ea86ad0479499cea602eda3f76162edaea3fdff44e12845 |
| 146 | RestaurantPOS14.frmRestaurantPOSEBRecord.resources | .NET resources | 180379 | a194f7b68645e5c5bb11f92911001a99603638333f12b7404fa064c31edc89b5 |
| 147 | RestaurantPOS14.frmRestaurantPOSHDRecord.resources | .NET resources | 180379 | a194f7b68645e5c5bb11f92911001a99603638333f12b7404fa064c31edc89b5 |
| 148 | RestaurantPOS14.frmRestaurantPOSHDRecord1.resources | .NET resources | 180379 | a194f7b68645e5c5bb11f92911001a99603638333f12b7404fa064c31edc89b5 |
| 149 | RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord_Unpaid.resources | .NET resources | 178301 | bc2c0ae0d78bd06e1ea86ad0479499cea602eda3f76162edaea3fdff44e12845 |
| 150 | RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord.resources | .NET resources | 180379 | a194f7b68645e5c5bb11f92911001a99603638333f12b7404fa064c31edc89b5 |
| 151 | RestaurantPOS14.frmRestaurantPOSKOTRecord.resources | .NET resources | 178301 | bc2c0ae0d78bd06e1ea86ad0479499cea602eda3f76162edaea3fdff44e12845 |
| 152 | RestaurantPOS14.frmRestaurantPOSTARecord_Unpaid.resources | .NET resources | 178301 | bc2c0ae0d78bd06e1ea86ad0479499cea602eda3f76162edaea3fdff44e12845 |
| 153 | RestaurantPOS14.frmRestaurantPOSTARecord.resources | .NET resources | 180379 | a194f7b68645e5c5bb11f92911001a99603638333f12b7404fa064c31edc89b5 |
| 154 | RestaurantPOS14.frmSecondaryDisplay.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 155 | RestaurantPOS14.frmSendBroadcastSMS.resources | .NET resources | 7083 | 7905f33d2257354275979557e89c05f29e7f942305914bc71ae03ff7f812eca2 |
| 156 | RestaurantPOS14.frmSendEmail.resources | .NET resources | 172312 | d6c9a0c5359bae3908f36d4699d1e978a05323b8840b5b9e32568a4be33c5f80 |
| 157 | RestaurantPOS14.frmSetDiscount.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 158 | RestaurantPOS14.frmSetNOP.resources | .NET resources | 165072 | 0be0d8d0898bed001564e4dc8f9f63f3a263eb5ef3c2ab7c62f67f5d99cd32a8 |
| 159 | RestaurantPOS14.frmSettings.resources | .NET resources | 236571 | 85d6678a1d901131696087a3de123cd65197b105218f600b5b5fe0b7b8b84308 |
| 160 | RestaurantPOS14.frmSMSSetting.resources | .NET resources | 14472 | 070d80117590365982c891f1804fd8faa9c7ed68729e9c826f0efe588c2622ec |
| 161 | RestaurantPOS14.frmSoftwareLicenceRenewal.resources | .NET resources | 172652 | 8b92481023988cf4a1563dcb70b11b5c2c2e2deba0aab01481988e9b6ea728c2 |
| 162 | RestaurantPOS14.frmSplash.resources | .NET resources | 168495 | 3b6e7ac3a172986a14328ce9a3e18629c6fa31239b23cb86356ddcb577f1abd4 |
| 163 | RestaurantPOS14.frmSqlServerSetting.resources | .NET resources | 178879 | a1658cb0785d246e04920574dc11dec2735e92bcb659aed5c8aafa8de797a716 |
| 164 | RestaurantPOS14.frmStock_Store.resources | .NET resources | 184341 | 9500acbf564084396bc76c5be5c49978db9be5fe3c8912a68dc866fa02352424 |
| 165 | RestaurantPOS14.frmStock_StoreRecord.resources | .NET resources | 175784 | 2c042e6403328ce8998806e2eca98beed4b67ffdcaa862f575c33945ea19cc3f |
| 166 | RestaurantPOS14.frmStockAdjustment_MI_Record.resources | .NET resources | 174479 | 6b7bfa6e56924e47eee200d73bdc36bf9456818f35e3dcf2ec219ff7799b72be |
| 167 | RestaurantPOS14.frmStockAdjustment_MI.resources | .NET resources | 182652 | ca2b831c2ad02e4311659ea987047d30518b7d1ea6e6af679aabb639798bffc8 |
| 168 | RestaurantPOS14.frmStockAdjustment_Store_Record.resources | .NET resources | 174479 | 6b7bfa6e56924e47eee200d73bdc36bf9456818f35e3dcf2ec219ff7799b72be |
| 169 | RestaurantPOS14.frmStockAdjustment_Store.resources | .NET resources | 182652 | ca2b831c2ad02e4311659ea987047d30518b7d1ea6e6af679aabb639798bffc8 |
| 170 | RestaurantPOS14.frmStockAdjustment_Warehouse_Record.resources | .NET resources | 174479 | 6b7bfa6e56924e47eee200d73bdc36bf9456818f35e3dcf2ec219ff7799b72be |
| 171 | RestaurantPOS14.frmStockAdjustment_Warehouse.resources | .NET resources | 182652 | ca2b831c2ad02e4311659ea987047d30518b7d1ea6e6af679aabb639798bffc8 |
| 172 | RestaurantPOS14.frmStockAdjustment.resources | .NET resources | 170700 | b820f4f57ea460a5523e98806763dc090f2c77ab5b079fb97ff48d5264c0e040 |
| 173 | RestaurantPOS14.frmStockIn_RM.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 174 | RestaurantPOS14.frmStockIn_StoreRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 175 | RestaurantPOS14.frmStockInRecord.resources | .NET resources | 175784 | 2c042e6403328ce8998806e2eca98beed4b67ffdcaa862f575c33945ea19cc3f |
| 176 | RestaurantPOS14.frmStockOUT_RM.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 177 | RestaurantPOS14.frmStockOUT_StoreRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 178 | RestaurantPOS14.frmStockOUTRecord.resources | .NET resources | 173706 | 6e8c25fa3c24fafae6566e7d9ed1ca7fb2ddd350987ea632722869efc34b1564 |
| 179 | RestaurantPOS14.frmStockTransfer.resources | .NET resources | 32853 | 9610624ca49dd37a900c3686a836ebf07e2f68efed30696285bf86ecd7bed7d0 |
| 180 | RestaurantPOS14.frmStockTransferRecord.resources | .NET resources | 175784 | 2c042e6403328ce8998806e2eca98beed4b67ffdcaa862f575c33945ea19cc3f |
| 181 | RestaurantPOS14.frmSupplier.resources | .NET resources | 182551 | 9c0144eaaad96cff95611d415f3146dfd47654035b4e0762a96dc0d0f23ce3c2 |
| 182 | RestaurantPOS14.frmSupplierRecord.resources | .NET resources | 176310 | c44c7082561594d519b8e6169dd061d0363667b5bc41a643b264d9fa8fc8ce1b |
| 183 | RestaurantPOS14.frmSystemInfo.resources | .NET resources | 108132 | cf73fcc16eda0d82911b92da040ff3e57d2568a3580f84d253952ae95417f818 |
| 184 | RestaurantPOS14.frmTable.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 185 | RestaurantPOS14.frmTableLayout.resources | .NET resources | 170819 | 8b0d3a0e33385aa7f51cc80ac4a311aa228cec4928b81393cb163e060906eaa8 |
| 186 | RestaurantPOS14.frmTableLayoutSettings.resources | .NET resources | 532023 | 78fb530d9e252aef68b62e0b70d44aa069106ab262c7a7b6aa69dfffe2b82a51 |
| 187 | RestaurantPOS14.frmTableList.resources | .NET resources | 171721 | 5cd57056e287dc6710ca54d01fa0502fc6e940272dd3a9cb693fc4be9b9e62b9 |
| 188 | RestaurantPOS14.frmTableMapping_Waiter.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 189 | RestaurantPOS14.frmTableReservation.resources | .NET resources | 246241 | 40a8e879ee8d51ee3cf526b0d00eecde7832e7c62c0144ec7785517478666590 |
| 190 | RestaurantPOS14.frmTablesExportImport.resources | .NET resources | 177047 | f1af3f2bdb26539f9e9055a1f85a9718a11b571849a05716cedcd892a2065dc4 |
| 191 | RestaurantPOS14.frmTerminalSetting.resources | .NET resources | 173242 | 498180a8e64e896b6bc5d7dfaf89be4342815bd4a366aea91fd6ecce9bcf4f86 |
| 192 | RestaurantPOS14.frmTestDualDisplay.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 193 | RestaurantPOS14.frmToppingsList.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 194 | RestaurantPOS14.frmToppingsList1.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 195 | RestaurantPOS14.frmUnit.resources | .NET resources | 180729 | e3e0945340736f2d7308c98a982c0ac7f7bb39149594588cbf1c42a13332bb2f |
| 196 | RestaurantPOS14.frmUserRights.resources | .NET resources | 101289 | 5a787704ead05683744a5a3765a89acfd66c52fdc824af852a8bf05c1a324816 |
| 197 | RestaurantPOS14.frmVIPMemberCard.resources | .NET resources | 10089 | 50f10296e074dc5648ffcec81db7c3169184e7aa1de5c86496686333d8d871eb |
| 198 | RestaurantPOS14.frmVoucher.resources | .NET resources | 191137 | b3210b383f556d42e19c62544d38b759d5c5173ed86fbcbc56f5177de1900af6 |
| 199 | RestaurantPOS14.frmVoucherRecord.resources | .NET resources | 178388 | 5180a575c087a010a56a8f8e160959277d8627cdd2921a3275989bd1cf64b268 |
| 200 | RestaurantPOS14.frmWaiterList.resources | .NET resources | 170899 | 8ef57f10e3b4f381bee347536511e7763f773541f3cbef3e90ff8018ca1fd1a8 |
| 201 | RestaurantPOS14.frmWalletList.resources | .NET resources | 170819 | 8b0d3a0e33385aa7f51cc80ac4a311aa228cec4928b81393cb163e060906eaa8 |
| 202 | RestaurantPOS14.frmWalletType.resources | .NET resources | 182480 | ed9670140eef53cd7650572ac06986d5679551615b26b214c92ae05bdf8ecd53 |
| 203 | RestaurantPOS14.frmWarehouse.resources | .NET resources | 25959 | 6b4bed3095b4ac80edadc26c63b70ab1c821f2ce3ffaa0eda59f411a06285948 |
| 204 | RestaurantPOS14.frmWarehouseType.resources | .NET resources | 80744 | 8c685d2bd9fbb7bd131015202013d5e3bbd57c21fea30a0690e568ec1965a114 |
| 205 | RestaurantPOS14.frmWorkPeriod_Del.resources | .NET resources | 174993 | e2df0420be2581b0b7e8f232b36b54e2433285aca9fc78fe6a8a42ed864cbcbb |
| 206 | RestaurantPOS14.frmWorkPeriod.resources | .NET resources | 170821 | 570be0dbbbe2a31462967d89cbcb635e5da596f5c93bd946f2004fa7004da8d7 |
| 207 | RestaurantPOS14.frmWorkPeriodReport.resources | .NET resources | 176998 | e38287ad5a0207043130a1f42676f3fb81a13c66cb1929be1d5aae68f2f5f6d3 |
| 208 | RestaurantPOS14.frmWPReport_CRViewer.resources | .NET resources | 170048 | b700fd2686ce31e7a7502d9eef449c05d3b0a18f72f75de5cd3ef2c7800624d8 |
| 209 | RestaurantPOS14.Resources.resources | .NET resources | 455442 | 1f38a57b405df2f2dee416aa064a093648cb6526951069dfe88038ff192a4096 |
| 210 | RestaurantPOS14.rptBalanceReceipt.rpt | Crystal report | 12288 | 3e80aa60e745f0677932d9f1886b17dad58987cd54bba1c9cf44744e6fef7e24 |
| 211 | RestaurantPOS14.rptBalanceSheet.rpt | Crystal report | 13824 | c7318616ad186cac4a2c454adf637a66011202c96a1e6d6b0f5e594fd58a833c |
| 212 | RestaurantPOS14.rptBankAccountStatements.rpt | Crystal report | 11776 | e6389e57a0b6be6bc731172aa60aff7f8594fce75bb0b11fa02c173b67138572 |
| 213 | RestaurantPOS14.rptBankAccountStatements1.rpt | Crystal report | 12800 | 38b49d457601aa0acbd75f76e861495972374f96857537c3a1472e3568d6f8a4 |
| 214 | RestaurantPOS14.rptBarcodeLabelPrinting.rpt | Crystal report | 16384 | 71b1f7c3f968641a5b92b034f3335f6c179cdcdbffad2778e677013b0778334a |
| 215 | RestaurantPOS14.rptCollectionsByDP.rpt | Crystal report | 12800 | a7e35b1beae5531f64239dcb053812d0640b114fb0f52082bb34ddb714260a30 |
| 216 | RestaurantPOS14.rptCollectionsByDP1.rpt | Crystal report | 12288 | f20b1a645d2bc90631cd0991cc3beefafd2ae7e61e7e9ebbb606ca2f4874b1bc |
| 217 | RestaurantPOS14.rptCollectionsByWaiter.rpt | Crystal report | 12288 | defb42290394ed92b51ef0c0c75d4bbfa154429cac7e1f907b0a870dd81637ac |
| 218 | RestaurantPOS14.rptCreditCustomerBalance.rpt | Crystal report | 9216 | fca6577e1447774de72c059513a7aca37d9e8c8983b620eb45803ef0f063c1bc |
| 219 | RestaurantPOS14.rptCreditCustomerLedger.rpt | Crystal report | 16384 | 8dd57ea588ab9848354923b3ea3e0d4c03fd7f5422a269bc4e5d0a01dbfcdd2f |
| 220 | RestaurantPOS14.rptCreditCustomerLedger1.rpt | Crystal report | 13312 | ad49470c948bdaa4069079174a51d176efb3a1b30662bcaea0351f509a52d418 |
| 221 | RestaurantPOS14.rptCreditors.rpt | Crystal report | 10240 | 6556b54c1aa5909aa671807f75f3dd5e29f6cd1e19812ce525c02dc2dbf1dc15 |
| 222 | RestaurantPOS14.rptDeletedBills.rpt | Crystal report | 11776 | 4c21c7932c54972ed4e759ed38e3c1440d18981d16626c21d1e48fc84cfd275d |
| 223 | RestaurantPOS14.rptDeletedItems.rpt | Crystal report | 12288 | c711d1999820796de27189a87678884f79562668968948d3b94485a1ef99cb77 |
| 224 | RestaurantPOS14.rptExpenses.rpt | Crystal report | 13824 | 63152b2c7b44b554611ce4ce863d937d17d9074351d4efd27859b45d3ddfa5d2 |
| 225 | RestaurantPOS14.rptFundDepositReceipt.rpt | Crystal report | 12800 | 7620be8c745576292f5ea3bd3b2e19a54f46dce1b43811707f40a1d3633f75a9 |
| 226 | RestaurantPOS14.rptGeneralDayBook.rpt | Crystal report | 16384 | 9f3f83745b184f2afcc58b9c9ebb01b3a18e93ca5626d4be2b809cba9f5a4734 |
| 227 | RestaurantPOS14.rptGeneralLedger.rpt | Crystal report | 16384 | 241774556901cc5708a0e31fa2a2606ceb2f663697fe26a09a50512ad7c7e3f5 |
| 228 | RestaurantPOS14.rptGiftCard.rpt | Crystal report | 9216 | 39a3bc8ec7ac9bb76ea14cc6567974cbc63e51929558ad95521eedd550793d2b |
| 229 | RestaurantPOS14.rptInputTax.rpt | Crystal report | 32768 | 75fba11453cb181e5a650e49d717ce4d33f8cb6c11daa767efd4ce191418701c |
| 230 | RestaurantPOS14.rptInvoiceSummary_CC.rpt | Crystal report | 14848 | 9af8f25bfea7b808512c2026575cc112f1fe50e0b2095ad9e87110e6727b09ac |
| 231 | RestaurantPOS14.rptLoyaltyCard.rpt | Crystal report | 16384 | a140d9988e9c7aff07d80a06399096e130f00cb790b2174aab5c5a099e32fde4 |
| 232 | RestaurantPOS14.rptLoyaltyCardMemberBalance.rpt | Crystal report | 16384 | 709f6ce924aa59fb4ba32f08ffcfca172c1568ec1be8f13a0fa68585a102e651 |
| 233 | RestaurantPOS14.rptLoyaltyCardMemberLedger.rpt | Crystal report | 13312 | caf769828fc18eee393c4906aa8aef33662f4fb4b924933c7021ec9af0bc204c |
| 234 | RestaurantPOS14.rptLoyaltyCardMemberLedger1.rpt | Crystal report | 13312 | c7008008b33b89b74d2566eee78cfc616298ac063bb9eff87021bfd57742771d |
| 235 | RestaurantPOS14.rptMemberBalance.rpt | Crystal report | 9216 | a8e1a6aacc5a7c983cee94ef48671de2d33e3da00a05361f7638c9e1c10ecfa0 |
| 236 | RestaurantPOS14.rptMemberLedger.rpt | Crystal report | 16384 | c39ce2dc6948b1857115f7981b56dd5e63fe2e17dd5e30548bd7a6ee936743fb |
| 237 | RestaurantPOS14.rptMemberLedger1.rpt | Crystal report | 16384 | e7b16f01f61293dabeb601455d6bd4f2db4a2cc29ec30455c23b64103dbe4d4f |
| 238 | RestaurantPOS14.rptMenuItems.rpt | Crystal report | 16384 | 76c1c73b86a5e1230b67a6611846481db22ff5efd64b3b63624a3e01ae8e17fd |
| 239 | RestaurantPOS14.rptPayment_WithdrawalReceipt.rpt | Crystal report | 12288 | c881fd938495c50284dd2cbba54ea9fe9327fa3cfe313b5a64a4f0c5a26cd776 |
| 240 | RestaurantPOS14.rptPaymentInvoice.rpt | Crystal report | 13824 | 9a74b7aa6003f98952aff2869a5b6e9387be92aa05eba085585d25afd27d173e |
| 241 | RestaurantPOS14.rptPOS80mmByOperator.rpt | Crystal report | 13312 | 5dc2078ae92648cea1cb84d52713fd76a09edeecd8c0c733a16b950f89318350 |
| 242 | RestaurantPOS14.rptPOSA4.rpt | Crystal report | 16384 | 2229030b90858ed3af12cf434c87ce80e899984b2f65d75b5a057a13d2c83857 |
| 243 | RestaurantPOS14.rptPOSA4ByOperator.rpt | Crystal report | 13312 | 68b835a6ff198e90776e17bc66318226b14f73deb45a305b38e6adaa1b2df598 |
| 244 | RestaurantPOS14.rptPOSA4X.rpt | Crystal report | 13312 | b4184a18e963a251c31f80b0f7e08333c9e544504196f36bdf5233ca6b8f5a82 |
| 245 | RestaurantPOS14.rptPurchase.rpt | Crystal report | 17408 | eb01158d25740f9690ee4683be2765932dbdcb0bb97b490cab3995d88014160c |
| 246 | RestaurantPOS14.rptPurchaseDayBook.rpt | Crystal report | 16384 | b83b88cd63717fcc62a91a41306452b6bf37f838d112e50a2647f44b175ef795 |
| 247 | RestaurantPOS14.rptPurchaseOrder.rpt | Crystal report | 15872 | 20de90f4ab619c0e9dfd27fb7a0156ed790c2a1389b76c1a98ba2ebde3ca816d |
| 248 | RestaurantPOS14.rptReceipt.rpt | Crystal report | 13824 | a94662d3219ab133d2720707a6778539780d309a1d902d3ba1e8f1fa5970c048 |
| 249 | RestaurantPOS14.rptReceiptTP.rpt | Crystal report | 13312 | 55874f47c53b0d7b3a4094aad5af385dcf3d4912e8d96bcac40e15c511f8545f |
| 250 | RestaurantPOS14.rptRecipe.rpt | Crystal report | 14848 | 302371b63da172c0caf12f7416c0cdff12cee57bb0c62a9b0ba69b3663de3d66 |
| 251 | RestaurantPOS14.rptRestaurantPOS.rpt | Crystal report | 32768 | 3874760326c57977bf7bf991c7d3269b4dfdfe0c674f683d967449b74d7af3bc |
| 252 | RestaurantPOS14.rptRestaurantPOSEB.rpt | Crystal report | 32768 | 35d6055a9781fb08963105dad34cd481c5368b5a3d956bc02d55a64670de8f5c |
| 253 | RestaurantPOS14.rptRestaurantPOSEBInvoice_Kitchen.rpt | Crystal report | 16384 | 558469945fcb3692420ec51855ee66f7640f79bc9167a838938ca76e465b2519 |
| 254 | RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt | Crystal report | 32768 | eaa2d00bfc576fdbe544c3b3430d3df873b7a9536f36ccbebf83df86a12d4e41 |
| 255 | RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt | Crystal report | 19968 | 74adb5891c172a61f921a183d8ce734cc6ee45227946aecb4d02b4554a127af0 |
| 256 | RestaurantPOS14.rptRestaurantPOSHD.rpt | Crystal report | 32768 | c8f731636b4db112bd261113733cc422e26d7d2d8305dcc1fe1243aa172d890c |
| 257 | RestaurantPOS14.rptRestaurantPOSHDInvoice_Kitchen.rpt | Crystal report | 32768 | e11497ddd992795c2a541ecaf7cd25f1544c0d500c6f9c99fff4174bbc48dade |
| 258 | RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt | Crystal report | 32768 | 7005b76c0d4a43b3bbf119c6a2d966d5764683c1bfdddc14e9e548c5e275c60c |
| 259 | RestaurantPOS14.rptRestaurantPOSKOTInvoice_Kitchen.rpt | Crystal report | 32768 | a45b9c7abb2bf3dae72f1cb14e4bf7d5cd28e880d8b0c3231fc3ec0096e4b76b |
| 260 | RestaurantPOS14.rptRestaurantPOSTA.rpt | Crystal report | 32768 | 91454c063436c9baf954ccfb29063de5171d6e3bc1988fe60a6ebc019067e431 |
| 261 | RestaurantPOS14.rptRestaurantPOSTAInvoice_Kitchen.rpt | Crystal report | 32768 | 0551decc9fc555d540b5a38566384fe05caa5c15532fc0813cfce16c44e46add |
| 262 | RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt | Crystal report | 19968 | 82174d81c26eed90e3e31c22b812e2ba35144cfcc1b8f5a278e44405e5758aba |
| 263 | RestaurantPOS14.rptRestaurantPOSUpdatedKOTInvoice_Kitchen.rpt | Crystal report | 32768 | 3805e649d94bbb92022205b22732bad6b0623a7485a3c2d7c64c938ab21d2073 |
| 264 | RestaurantPOS14.rptRestaurantPOSVoidKOT_Kitchen.rpt | Crystal report | 16384 | e58caf46cb6e85142fcfaa60d83ebc99644aa13316fe832a97796749d1b5b555 |
| 265 | RestaurantPOS14.rptRPOS.rpt | Crystal report | 81920 | 7180e55365c772cb45f7dfeaec1f9bbfcef103dc36f1c1129260a36980d4a4d4 |
| 266 | RestaurantPOS14.rptRPOS1.rpt | Crystal report | 81920 | 1d354f286ed56d6446157ebae2e40b72aed6263df91a974a5dbb96f09caeaff3 |
| 267 | RestaurantPOS14.rptRPOS2.rpt | Crystal report | 81920 | c42dd471c2123ec634446394a72e1185ecbf84ac6b45e2d4106d6a4f9cfb27ce |
| 268 | RestaurantPOS14.rptRPOSByKitchen.rpt | Crystal report | 32768 | 2ba80eb3d868d956fe567e450d181881c8fd7003dec953c5c06b13448a7ca693 |
| 269 | RestaurantPOS14.rptRPOSByMonth.rpt | Crystal report | 16384 | 5fefe13225f65aa0d202190e448f863986bb4e3519495f7f38cb6b3167b27945 |
| 270 | RestaurantPOS14.rptRPOSCard.rpt | Crystal report | 9728 | 8dd1e49648e52fe5e103d1ff383a99b661a781c29390b8d60300c3b747d0b37d |
| 271 | RestaurantPOS14.rptSalarySlip_MB.rpt | Crystal report | 32768 | bc13fbfe54cf762e1069354a80447f52e61ffc2f3aec30f0af30340b0ba21511 |
| 272 | RestaurantPOS14.rptSalarySlip.rpt | Crystal report | 12800 | f5ffd9bd4be4cbc43c5718fac1c3185780d818d9f0fa4884af1ccf7c6a8c548d |
| 273 | RestaurantPOS14.rptStockTransfer.rpt | Crystal report | 32768 | a4e7395b316b353a07cd7d44d3fb678e2bf6fc8073523397cc1689698cda2ac1 |
| 274 | RestaurantPOS14.rptStockTransferInvoice.rpt | Crystal report | 16384 | b979d67065eb25e4414e412515f692e917d5bef55cacc0ba62555fd234f417e3 |
| 275 | RestaurantPOS14.rptSupplierLedger.rpt | Crystal report | 15360 | 4b304eac68c9a193d4684f8954d305e198de8cfaa3327f799b1c61f06865f644 |
| 276 | RestaurantPOS14.rptTax.rpt | Crystal report | 13312 | c06e73465034db6b08847ac3559c6c2a168edd0e2de30d861403ec051c6f2b1b |
| 277 | RestaurantPOS14.rptTrialBalance.rpt | Crystal report | 11776 | b1e344e375758b923b458803aba29c5f4236ba8d66c1460ff32bd9eec32d11f1 |
| 278 | RestaurantPOS14.rptVoidKOT.rpt | Crystal report | 11776 | 4119143ce2971c27b9ed77ec465bbc7194f669aafa3284202c854a3d857de117 |
| 279 | RestaurantPOS14.rptVoucher.rpt | Crystal report | 12288 | a1aacb0faee0eaef9ac6e043dcac0ea4f2f75758ee268f95b98d6682e1942f7a |
| 280 | RestaurantPOS14.rptWPByKitchen.rpt | Crystal report | 32768 | 9f5ffb3aa93d77c0b6addd04c1fd16a901edf043fa3f040da177a9d839fd621f |

## Crystal report wrapper/resource mapping

| ReportClass type | ResourceName return value | Embedded logical name | Exact match |
|---|---|---|---|
| RestaurantPOS14.rptBalanceReceipt | rptBalanceReceipt.rpt | RestaurantPOS14.rptBalanceReceipt.rpt | yes |
| RestaurantPOS14.rptBalanceSheet | rptBalanceSheet.rpt | RestaurantPOS14.rptBalanceSheet.rpt | yes |
| RestaurantPOS14.rptBankAccountStatements | rptBankAccountStatements.rpt | RestaurantPOS14.rptBankAccountStatements.rpt | yes |
| RestaurantPOS14.rptBankAccountStatements1 | rptBankAccountStatements1.rpt | RestaurantPOS14.rptBankAccountStatements1.rpt | yes |
| RestaurantPOS14.rptBarcodeLabelPrinting | rptBarcodeLabelPrinting.rpt | RestaurantPOS14.rptBarcodeLabelPrinting.rpt | yes |
| RestaurantPOS14.rptCollectionsByDP | rptCollectionsByDP.rpt | RestaurantPOS14.rptCollectionsByDP.rpt | yes |
| RestaurantPOS14.rptCollectionsByDP1 | rptCollectionsByDP1.rpt | RestaurantPOS14.rptCollectionsByDP1.rpt | yes |
| RestaurantPOS14.rptCollectionsByWaiter | rptCollectionsByWaiter.rpt | RestaurantPOS14.rptCollectionsByWaiter.rpt | yes |
| RestaurantPOS14.rptCreditCustomerBalance | rptCreditCustomerBalance.rpt | RestaurantPOS14.rptCreditCustomerBalance.rpt | yes |
| RestaurantPOS14.rptCreditCustomerLedger | rptCreditCustomerLedger.rpt | RestaurantPOS14.rptCreditCustomerLedger.rpt | yes |
| RestaurantPOS14.rptCreditCustomerLedger1 | rptCreditCustomerLedger1.rpt | RestaurantPOS14.rptCreditCustomerLedger1.rpt | yes |
| RestaurantPOS14.rptCreditors | rptCreditors.rpt | RestaurantPOS14.rptCreditors.rpt | yes |
| RestaurantPOS14.rptDeletedBills | rptDeletedBills.rpt | RestaurantPOS14.rptDeletedBills.rpt | yes |
| RestaurantPOS14.rptDeletedItems | rptDeletedItems.rpt | RestaurantPOS14.rptDeletedItems.rpt | yes |
| RestaurantPOS14.rptExpenses | rptExpenses.rpt | RestaurantPOS14.rptExpenses.rpt | yes |
| RestaurantPOS14.rptFundDepositReceipt | rptFundDepositReceipt.rpt | RestaurantPOS14.rptFundDepositReceipt.rpt | yes |
| RestaurantPOS14.rptGeneralDayBook | rptGeneralDayBook.rpt | RestaurantPOS14.rptGeneralDayBook.rpt | yes |
| RestaurantPOS14.rptGeneralLedger | rptGeneralLedger.rpt | RestaurantPOS14.rptGeneralLedger.rpt | yes |
| RestaurantPOS14.rptGiftCard | rptGiftCard.rpt | RestaurantPOS14.rptGiftCard.rpt | yes |
| RestaurantPOS14.rptInputTax | rptInputTax.rpt | RestaurantPOS14.rptInputTax.rpt | yes |
| RestaurantPOS14.rptInvoiceSummary_CC | rptInvoiceSummary_CC.rpt | RestaurantPOS14.rptInvoiceSummary_CC.rpt | yes |
| RestaurantPOS14.rptLoyaltyCard | rptLoyaltyCard.rpt | RestaurantPOS14.rptLoyaltyCard.rpt | yes |
| RestaurantPOS14.rptLoyaltyCardMemberBalance | rptLoyaltyCardMemberBalance.rpt | RestaurantPOS14.rptLoyaltyCardMemberBalance.rpt | yes |
| RestaurantPOS14.rptLoyaltyCardMemberLedger | rptLoyaltyCardMemberLedger.rpt | RestaurantPOS14.rptLoyaltyCardMemberLedger.rpt | yes |
| RestaurantPOS14.rptLoyaltyCardMemberLedger1 | rptLoyaltyCardMemberLedger1.rpt | RestaurantPOS14.rptLoyaltyCardMemberLedger1.rpt | yes |
| RestaurantPOS14.rptMemberBalance | rptMemberBalance.rpt | RestaurantPOS14.rptMemberBalance.rpt | yes |
| RestaurantPOS14.rptMemberLedger | rptMemberLedger.rpt | RestaurantPOS14.rptMemberLedger.rpt | yes |
| RestaurantPOS14.rptMemberLedger1 | rptMemberLedger1.rpt | RestaurantPOS14.rptMemberLedger1.rpt | yes |
| RestaurantPOS14.rptMenuItems | rptMenuItems.rpt | RestaurantPOS14.rptMenuItems.rpt | yes |
| RestaurantPOS14.rptPayment_WithdrawalReceipt | rptPayment_WithdrawalReceipt.rpt | RestaurantPOS14.rptPayment_WithdrawalReceipt.rpt | yes |
| RestaurantPOS14.rptPaymentInvoice | rptPaymentInvoice.rpt | RestaurantPOS14.rptPaymentInvoice.rpt | yes |
| RestaurantPOS14.rptPOS80mmByOperator | rptPOS80mmByOperator.rpt | RestaurantPOS14.rptPOS80mmByOperator.rpt | yes |
| RestaurantPOS14.rptPOSA4 | rptPOSA4.rpt | RestaurantPOS14.rptPOSA4.rpt | yes |
| RestaurantPOS14.rptPOSA4ByOperator | rptPOSA4ByOperator.rpt | RestaurantPOS14.rptPOSA4ByOperator.rpt | yes |
| RestaurantPOS14.rptPOSA4X | rptPOSA4X.rpt | RestaurantPOS14.rptPOSA4X.rpt | yes |
| RestaurantPOS14.rptPurchase | rptPurchase.rpt | RestaurantPOS14.rptPurchase.rpt | yes |
| RestaurantPOS14.rptPurchaseDayBook | rptPurchaseDayBook.rpt | RestaurantPOS14.rptPurchaseDayBook.rpt | yes |
| RestaurantPOS14.rptPurchaseOrder | rptPurchaseOrder.rpt | RestaurantPOS14.rptPurchaseOrder.rpt | yes |
| RestaurantPOS14.rptReceipt | rptReceipt.rpt | RestaurantPOS14.rptReceipt.rpt | yes |
| RestaurantPOS14.rptReceiptTP | rptReceiptTP.rpt | RestaurantPOS14.rptReceiptTP.rpt | yes |
| RestaurantPOS14.rptRecipe | rptRecipe.rpt | RestaurantPOS14.rptRecipe.rpt | yes |
| RestaurantPOS14.rptRestaurantPOS | rptRestaurantPOS.rpt | RestaurantPOS14.rptRestaurantPOS.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSEB | rptRestaurantPOSEB.rpt | RestaurantPOS14.rptRestaurantPOSEB.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSEBInvoice | rptRestaurantPOSEBInvoice.rpt | RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSEBInvoice_Kitchen | rptRestaurantPOSEBInvoice_Kitchen.rpt | RestaurantPOS14.rptRestaurantPOSEBInvoice_Kitchen.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice | rptRestaurantPOSFinalBillKOTInvoice.rpt | RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSHD | rptRestaurantPOSHD.rpt | RestaurantPOS14.rptRestaurantPOSHD.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSHDInvoice | rptRestaurantPOSHDInvoice.rpt | RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSHDInvoice_Kitchen | rptRestaurantPOSHDInvoice_Kitchen.rpt | RestaurantPOS14.rptRestaurantPOSHDInvoice_Kitchen.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSKOTInvoice_Kitchen | rptRestaurantPOSKOTInvoice_Kitchen.rpt | RestaurantPOS14.rptRestaurantPOSKOTInvoice_Kitchen.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSTA | rptRestaurantPOSTA.rpt | RestaurantPOS14.rptRestaurantPOSTA.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSTAInvoice | rptRestaurantPOSTAInvoice.rpt | RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSTAInvoice_Kitchen | rptRestaurantPOSTAInvoice_Kitchen.rpt | RestaurantPOS14.rptRestaurantPOSTAInvoice_Kitchen.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSUpdatedKOTInvoice_Kitchen | rptRestaurantPOSUpdatedKOTInvoice_Kitchen.rpt | RestaurantPOS14.rptRestaurantPOSUpdatedKOTInvoice_Kitchen.rpt | yes |
| RestaurantPOS14.rptRestaurantPOSVoidKOT_Kitchen | rptRestaurantPOSVoidKOT_Kitchen.rpt | RestaurantPOS14.rptRestaurantPOSVoidKOT_Kitchen.rpt | yes |
| RestaurantPOS14.rptRPOS | rptRPOS.rpt | RestaurantPOS14.rptRPOS.rpt | yes |
| RestaurantPOS14.rptRPOS1 | rptRPOS1.rpt | RestaurantPOS14.rptRPOS1.rpt | yes |
| RestaurantPOS14.rptRPOS2 | rptRPOS2.rpt | RestaurantPOS14.rptRPOS2.rpt | yes |
| RestaurantPOS14.rptRPOSByKitchen | rptRPOSByKitchen.rpt | RestaurantPOS14.rptRPOSByKitchen.rpt | yes |
| RestaurantPOS14.rptRPOSByMonth | rptRPOSByMonth.rpt | RestaurantPOS14.rptRPOSByMonth.rpt | yes |
| RestaurantPOS14.rptRPOSCard | rptRPOSCard.rpt | RestaurantPOS14.rptRPOSCard.rpt | yes |
| RestaurantPOS14.rptSalarySlip | rptSalarySlip.rpt | RestaurantPOS14.rptSalarySlip.rpt | yes |
| RestaurantPOS14.rptSalarySlip_MB | rptSalarySlip_MB.rpt | RestaurantPOS14.rptSalarySlip_MB.rpt | yes |
| RestaurantPOS14.rptStockTransfer | rptStockTransfer.rpt | RestaurantPOS14.rptStockTransfer.rpt | yes |
| RestaurantPOS14.rptStockTransferInvoice | rptStockTransferInvoice.rpt | RestaurantPOS14.rptStockTransferInvoice.rpt | yes |
| RestaurantPOS14.rptSupplierLedger | rptSupplierLedger.rpt | RestaurantPOS14.rptSupplierLedger.rpt | yes |
| RestaurantPOS14.rptTax | rptTax.rpt | RestaurantPOS14.rptTax.rpt | yes |
| RestaurantPOS14.rptTrialBalance | rptTrialBalance.rpt | RestaurantPOS14.rptTrialBalance.rpt | yes |
| RestaurantPOS14.rptVoidKOT | rptVoidKOT.rpt | RestaurantPOS14.rptVoidKOT.rpt | yes |
| RestaurantPOS14.rptVoucher | rptVoucher.rpt | RestaurantPOS14.rptVoucher.rpt | yes |
| RestaurantPOS14.rptWPByKitchen | rptWPByKitchen.rpt | RestaurantPOS14.rptWPByKitchen.rpt | yes |

## Preservable content/assets present beside the executable

| Asset | Present | Kind | Files | Bytes |
|---|---|---|---:|---:|
| BlankDBscript.sql | yes | file | 1 | 243066 |
| DBscript.sql | yes | file | 1 | 2165796 |
| IDAutomationHC39M.ttf | yes | file | 1 | 41732 |
| RPOSLatest.xml | yes | file | 1 | 3617 |
| POSReportA4.xml | yes | file | 1 | 2622 |
| OutputTaxZ.xml | yes | file | 1 | 2697 |
| CollectionByOperator.xml | yes | file | 1 | 1117 |
| LC.txt | yes | file | 1 | 3 |
| Menu Items Image | yes | directory | 2 | 15082 |
| Secondary Display Images | yes | directory | 0 | 0 |
| PDF Reports | yes | directory | 0 | 0 |
| Alter DB Script | yes | directory | 0 | 0 |

## Phase 1 implications

- Do not use the PDB to claim or mirror an original VB file organization; it records the prior C# reconstruction only.
- A VB.NET reconstruction remains possible in principle from IL and surviving VB patterns, but filenames, local names, `Handles` clauses, and original high-level error-flow constructs cannot be assumed to come from these symbols.
- The installed `ilspycmd` 9.1.0.7988 emits C# only. Phase 1 needs a VB-capable decompiler/reconstruction path or a deliberate manual IL-to-VB recovery workflow.
- Preserve the exact 71 report resources and their validated one-to-one wrapper mappings; do not plan for 284 reports unless another source artifact is supplied.
- Keep third-party assemblies binary-only. Their inventory and exact versions are in `docs/DEPENDENCIES.md`.
