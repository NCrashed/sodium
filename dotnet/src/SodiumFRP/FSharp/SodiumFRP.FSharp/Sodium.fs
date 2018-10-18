[<AutoOpen>]
module SodiumFRP.Sodium

let inline isActiveT () = Transaction.isActive ()
let inline runT f = Transaction.run f
let inline onStartT a = Transaction.onStart a
let inline postT a = Transaction.post a

let inline unlistenL listener = Listener.unlisten listener

let inline neverS<'a> () = Stream.never<'a> ()
let inline sinkS<'a> () = StreamSink.create<'a> ()
let inline sinkWithCoalesceS coalesce = StreamSink.createWithCoalesce coalesce
let inline sinkCS<'a> () = CellStreamSink.create<'a> ()
let inline sinkWithCoalesceCS coalesce = CellStreamSink.createWithCoalesce coalesce
let inline sendS a streamSink = StreamSink.send a streamSink
let inline loopS f = Stream.loop f
let inline loopWithNoCapturesS f = Stream.loopWithNoCaptures f
let inline listenWeakS handler stream = Stream.listenWeak handler stream
let inline listenS handler stream = Stream.listen handler stream
let inline attachListenerS listener stream = Stream.attachListener listener stream
let inline listenOnceS handler stream = Stream.listenOnce handler stream
let inline listenOnceAsyncS stream = Stream.listenOnceAsync stream
let inline mapS f stream = Stream.map f stream
let inline mapToS value stream = Stream.mapTo value stream
let inline holdS initialValue stream = Stream.hold initialValue stream
let inline holdLazyS initialValue stream = Stream.holdLazy initialValue stream
let inline snapshotB behavior f stream = Stream.snapshotB behavior f stream
let inline snapshotC cell f stream = Stream.snapshot cell f stream
let inline snapshotAndTakeB behavior stream = Stream.snapshotAndTakeB behavior stream
let inline snapshotAndTakeC cell stream = Stream.snapshotAndTake cell stream
let inline snapshot2B behavior1 behavior2 f stream = Stream.snapshot2B behavior1 behavior2 f stream
let inline snapshot2C cell1 cell2 f stream = Stream.snapshot2 cell1 cell2 f stream
let inline snapshot3B behavior1 behavior2 behavior3 f stream = Stream.snapshot3B behavior1 behavior2 behavior3 f stream
let inline snapshot3C cell1 cell2 cell3 f stream = Stream.snapshot3 cell1 cell2 cell3 f stream
let inline snapshot4B behavior1 behavior2 behavior3 behavior4 f stream = Stream.snapshot4B behavior1 behavior2 behavior3 behavior4 f stream
let inline snapshot4C cell1 cell2 cell3 cell4 f stream = Stream.snapshot4 cell1 cell2 cell3 cell4 f stream
let inline snapshot5B behavior1 behavior2 behavior3 behavior4 behavior5 f stream = Stream.snapshot5B behavior1 behavior2 behavior3 behavior4 behavior5 f stream
let inline snapshot5C cell1 cell2 cell3 cell4 cell5 f stream = Stream.snapshot5 cell1 cell2 cell3 cell4 cell5 f stream
let inline snapshot6B behavior1 behavior2 behavior3 behavior4 behavior5 behavior6 f stream = Stream.snapshot6B behavior1 behavior2 behavior3 behavior4 behavior5 behavior6 f stream
let inline snapshot6C cell1 cell2 cell3 cell4 cell5 cell6 f stream = Stream.snapshot6 cell1 cell2 cell3 cell4 cell5 cell6 f stream
let inline snapshot7B behavior1 behavior2 behavior3 behavior4 behavior5 behavior6 behavior7 f stream = Stream.snapshot7B behavior1 behavior2 behavior3 behavior4 behavior5 behavior6 behavior7 f stream
let inline snapshot7C cell1 cell2 cell3 cell4 cell5 cell6 cell7 f stream = Stream.snapshot7 cell1 cell2 cell3 cell4 cell5 cell6 cell7 f stream
let inline snapshot8B behavior1 behavior2 behavior3 behavior4 behavior5 behavior6 behavior7 behavior8 f stream = Stream.snapshot8B behavior1 behavior2 behavior3 behavior4 behavior5 behavior6 behavior7 behavior8 f stream
let inline snapshot8C cell1 cell2 cell3 cell4 cell5 cell6 cell7 cell8 f stream = Stream.snapshot8 cell1 cell2 cell3 cell4 cell5 cell6 cell7 cell8 f stream
let inline mergeS f (stream, stream2) = Stream.merge f (stream, stream2)
let inline orElseS (stream, stream2) = Stream.orElse (stream, stream2)
let inline filterS predicate stream = Stream.filter predicate stream
let inline filterOptionS stream = Stream.filterOption stream
let inline gateB behavior stream = Stream.gateB behavior stream
let inline gateC cell stream = Stream.gate cell stream
let inline collectLazyS initialState f stream = Stream.collectLazy initialState f stream
let inline collectS initialState f stream = Stream.collect initialState f stream
let inline calmWithCompareS compare stream = Stream.calmWithCompare compare stream
let inline calmWithEqualityComparerS equalityComparer stream = Stream.calmWithEqualityComparer equalityComparer stream
let inline calmS stream = Stream.calm stream
let inline accumLazyS initialState f stream = Stream.accumLazy initialState f stream
let inline accumS initialState f stream = Stream.accum initialState f stream
let inline onceS stream = Stream.once stream
let inline mergeAllS f streams = Stream.mergeAll f streams
let inline orElseAllS streams = Stream.orElseAll streams

let inline constantB value = Behavior.constant value
let inline constantLazyB value = Behavior.constantLazy value
let inline sinkB initialValue = BehaviorSink.create initialValue
let inline sinkWithCoalesceB initialValue coalesce = BehaviorSink.createWithCoalesce initialValue coalesce
let inline sendB a behaviorSink = BehaviorSink.send a behaviorSink
let inline loopB f = Behavior.loop f
let inline loopWithNoCapturesB f = Behavior.loopWithNoCaptures f
let inline sampleB behavior = Behavior.sample behavior
let inline sampleLazyB behavior = Behavior.sampleLazy behavior
let inline applyB f behavior = Behavior.apply f behavior
let inline mapB f behavior = Behavior.map f behavior
let inline lift2B f (behavior, behavior2) = Behavior.lift2 f (behavior, behavior2)
let inline lift3B f (behavior, behavior2, behavior3) = Behavior.lift3 f (behavior, behavior2, behavior3)
let inline lift4B f (behavior, behavior2, behavior3, behavior4) = Behavior.lift4 f (behavior, behavior2, behavior3, behavior4)
let inline lift5B f (behavior, behavior2, behavior3, behavior4, behavior5) = Behavior.lift5 f (behavior, behavior2, behavior3, behavior4, behavior5)
let inline lift6B f (behavior, behavior2, behavior3, behavior4, behavior5, behavior6) = Behavior.lift6 f (behavior, behavior2, behavior3, behavior4, behavior5, behavior6)
let inline lift7B f (behavior, behavior2, behavior3, behavior4, behavior5, behavior6, behavior7) = Behavior.lift7 f (behavior, behavior2, behavior3, behavior4, behavior5, behavior6, behavior7)
let inline lift8B f (behavior, behavior2, behavior3, behavior4, behavior5, behavior6, behavior7, behavior8) = Behavior.lift8 f (behavior, behavior2, behavior3, behavior4, behavior5, behavior6, behavior7, behavior8)
let inline liftAllB f behaviors = Behavior.liftAll f behaviors
let inline switchBB behavior = Behavior.switchB behavior
let inline switchCB behavior = Behavior.switchC behavior
let inline switchSB behavior = Behavior.switchS behavior

let inline constantC value = Cell.constant value
let inline constantLazyC value = Cell.constantLazy value
let inline sinkC initialValue = CellSink.create initialValue
let inline sinkWithCoalesceC initialValue coalesce = CellSink.createWithCoalesce initialValue coalesce
let inline sendC a cellSink = CellSink.send a cellSink
let inline loopC f = Cell.loop f
let inline loopWithNoCapturesC f = Cell.loopWithNoCaptures f
let inline sampleC cell = Cell.sample cell
let inline sampleLazyC cell = Cell.sampleLazy cell
let inline updatesC cell = Cell.updates cell
let inline valuesC cell = Cell.values cell
let inline asBehaviorC cell = Cell.asBehavior cell
let inline listenWeakC handler cell = Cell.listenWeak handler cell
let inline listenC handler cell = Cell.listen handler cell
let inline applyC f cell = Cell.apply f cell
let inline mapC f cell = Cell.map f cell
let inline lift2C f (cell, cell2) = Cell.lift2 f (cell, cell2)
let inline lift3C f (cell, cell2, cell3) = Cell.lift3 f (cell, cell2, cell3)
let inline lift4C f (cell, cell2, cell3, cell4) = Cell.lift4 f (cell, cell2, cell3, cell4)
let inline lift5C f (cell, cell2, cell3, cell4, cell5) = Cell.lift5 f (cell, cell2, cell3, cell4, cell5)
let inline lift6C f (cell, cell2, cell3, cell4, cell5, cell6) = Cell.lift6 f (cell, cell2, cell3, cell4, cell5, cell6)
let inline lift7C f (cell, cell2, cell3, cell4, cell5, cell6, cell7) = Cell.lift7 f (cell, cell2, cell3, cell4, cell5, cell6, cell7)
let inline lift8C f (cell, cell2, cell3, cell4, cell5, cell6, cell7, cell8) = Cell.lift8 f (cell, cell2, cell3, cell4, cell5, cell6, cell7, cell8)
let inline calmWithCompareC compare cell = Cell.calmWithCompare compare cell
let inline calmWithEqualityComparerC equalityComparer cell = Cell.calmWithEqualityComparer equalityComparer cell
let inline calmC cell = Cell.calm cell
let inline liftAllC f cells = Cell.liftAll f cells
let inline switchB cell = Cell.switchB cell
let inline switchC cell = Cell.switchC cell
let inline switchS cell = Cell.switchS cell