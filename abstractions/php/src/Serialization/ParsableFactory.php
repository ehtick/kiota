<?php
namespace Microsoft\Kiota\Abstractions\Serialization;

/**
 * Defines the factory for creating parsable objects.
 * The type of the parsable object.
 */
interface ParsableFactory {

    /**
     * Create a new parsable object from the given serialized data.
     * @param ParseNode $parseNode The node to parse use to get the discriminator value from the payload.
     * @return Parsable parsable object.
     */
    public function create(ParseNode $parseNode): Parsable;
}

