﻿namespace PusherClient
{
    class ErrorConstants
    {
        public const string ApplicationKeyNotSet = "The application key cannot be null or whitespace";
        public const string ConnectionAlreadyConnected = "Attempt to connect when another connection has already started. New attempt has been ignored.";
        public const string JsonSerializerNotProvided = "The options used for initialization must contain a value for JsonSerializer.";
    }
}
